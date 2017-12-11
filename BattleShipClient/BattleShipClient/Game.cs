using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;
using BattleShipClient.BattleShipServer;

namespace BattleShipClient
{
    public partial class GameForm : MetroForm
    {
        Graphics opponent, player;

        PlaceMode mode = PlaceMode.None;
        Image[] ships, explosions;

        playerInfo playerinfo = new playerInfo();
        playerInfo opponentinfo = new playerInfo();

        int[] target = new int[2] { 5, 5 };

        List<shipPlacement> placements = new List<shipPlacement>();

        int uid = -1;

        ServerClient client = new ServerClient();

        public GameForm()
        {
           
            InitializeComponent();
            playerCanvas.Image = new Bitmap(playerCanvas.Width, playerCanvas.Height);
            player = Graphics.FromImage(playerCanvas.Image);
            player.Clear(Color.LightCyan);
            opponentCanvas.Image = new Bitmap(playerCanvas.Width, playerCanvas.Height);
            opponent = Graphics.FromImage(opponentCanvas.Image);
            opponent.Clear(Color.LightCyan);

           
            try
            {
                uid = client.connect();
                if (uid == -1)
                {
                    MessageBox.Show("Server is full. Please try again later.");
                    System.Diagnostics.Process.GetCurrentProcess().Kill();
                }
                playerNametxt.Text = "Player " + uid.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                System.Diagnostics.Process.GetCurrentProcess().Kill();
            }
            for (int x = 1; x < 10; x++)
            {
                for (int y = 1; y < 10; y++)
                {
                    player.DrawLine(Pens.Black, x * 32, 0, x * 32, 320);
                    opponent.DrawLine(Pens.Black, x * 32, 0, x * 32, 320);
                    player.DrawLine(Pens.Black, 0, y * 32, 320, y * 32);
                    opponent.DrawLine(Pens.Black, 0, y * 32, 320, y * 32);
                }
            }


        }

        private void Game_Load(object sender, EventArgs e)
        {
            ships = new Image[10]
           {
                Bitmap.FromFile("Sprites\\Boat.bmp"),
                Bitmap.FromFile("Sprites\\Destroyer.bmp"),
                Bitmap.FromFile("Sprites\\Submarine.bmp"),
                Bitmap.FromFile("Sprites\\Battleship.bmp"),
                Bitmap.FromFile("Sprites\\Carrier.bmp"),

                RotateImage(Bitmap.FromFile("Sprites\\Boat.bmp")),
                RotateImage(Bitmap.FromFile("Sprites\\Destroyer.bmp")),
                RotateImage(Bitmap.FromFile("Sprites\\Submarine.bmp")),
                RotateImage(Bitmap.FromFile("Sprites\\Battleship.bmp")),
                RotateImage(Bitmap.FromFile("Sprites\\Carrier.bmp")) };
            for (int i = 0; i < ships.Length; i++)
                ((Bitmap)ships[i]).MakeTransparent(Color.White);

            explosions = new Image[2]
            { Bitmap.FromFile("Sprites\\Splash.bmp") ,
            Bitmap.FromFile("Sprites\\Explosion.bmp")};
            for (int i = 0; i < explosions.Length; i++)
                ((Bitmap)explosions[i]).MakeTransparent(Color.White);

        }

        private Image RotateImage(Image image)
        {
            image.RotateFlip(RotateFlipType.Rotate90FlipX);
            return image;
        }

        private void carrierBtn_Click(object sender, EventArgs e)
        {
            if (verticalRadio.Checked)
                mode = PlaceMode.VCarrier;
            else if (horizontalRadio.Checked)
                mode = PlaceMode.HCarrier;
        }

        private void battleShipBtn_Click(object sender, EventArgs e)
        {
            if (verticalRadio.Checked)
                mode = PlaceMode.VBattleship;
            else if (horizontalRadio.Checked)
                mode = PlaceMode.HBattleship;
        }

        private void submarineBtn_Click(object sender, EventArgs e)
        {
            if (verticalRadio.Checked)
                mode = PlaceMode.VSubmarine;
            else if (horizontalRadio.Checked)
                mode = PlaceMode.HSubmarine;
        }

        private void destroyerBtn_Click(object sender, EventArgs e)
        {
            if (verticalRadio.Checked)
                mode = PlaceMode.VDestroyer;
            else if (horizontalRadio.Checked)
                mode = PlaceMode.HDestroyer;
        }

        private void boatBtn_Click(object sender, EventArgs e)
        {
            if (verticalRadio.Checked)
                mode = PlaceMode.VBoat;
            else if (horizontalRadio.Checked)
                mode = PlaceMode.HBoat;
        }

        private void playerCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            player.Clear(Color.LightCyan);
            opponent.Clear(Color.LightCyan);

            for (int x = 1; x < 10; x++)
            {
                for (int y = 1; y < 10; y++)
                {
                    player.DrawLine(Pens.Black, x * 32, 0, x * 32, 320);
                    opponent.DrawLine(Pens.Black, x * 32, 0, x * 32, 320);
                    player.DrawLine(Pens.Black, 0, y * 32, 320, y * 32);
                    opponent.DrawLine(Pens.Black, 0, y * 32, 320, y * 32);
                }
            }
            switch (mode)
            {
                case PlaceMode.HCarrier:
                case PlaceMode.HBattleship:
                case PlaceMode.HSubmarine:
                case PlaceMode.HDestroyer:
                case PlaceMode.HBoat:
                case PlaceMode.VCarrier:
                case PlaceMode.VBattleship:
                case PlaceMode.VSubmarine:
                case PlaceMode.VDestroyer:
                case PlaceMode.VBoat:
                    Draw();
                    player.DrawImage(ships[(int)mode], (e.X / 32) * 32, (e.Y / 32) * 32);
                    playerCanvas.Refresh();
                    break;
            }
        }

        private void playerCanvas_MouseLeave(object sender, EventArgs e)
        {
            Draw();
        }

        private void verticalRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (mode != PlaceMode.None && verticalRadio.Checked)
                mode = (PlaceMode)((int)mode - 5);
        }

        private void horizontalRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (mode != PlaceMode.None && horizontalRadio.Checked)
                mode = (PlaceMode)((int)mode + 5);
        }

        private void playerNametxt_TextChanged(object sender, EventArgs e)
        {
            client.SetName(uid, playerNametxt.Text);
        }

        private void playerCanvas_Click(object sender, EventArgs e)
        {
            MouseEventArgs m = (MouseEventArgs)e;
            shipPlacement ship;
            switch (mode)
            {
                case PlaceMode.HCarrier:
                case PlaceMode.VCarrier:
                    ship = new shipPlacement() { x = (m.X / 32) * 32, y = (m.Y / 32) * 32, placement = mode };
                    if (client.PlaceShip(uid, ship))
                    {
                        placements.Add(ship);
                        carrierBtn.Visible = false;
                    }
                    mode = PlaceMode.None;
                    break;
                case PlaceMode.HBattleship:
                case PlaceMode.VBattleship:
                    ship = new shipPlacement() { x = (m.X / 32) * 32, y = (m.Y / 32) * 32, placement = mode };
                    if (client.PlaceShip(uid, ship))
                    {
                        placements.Add(ship);
                        battleShipBtn.Visible = false;
                    }
                    mode = PlaceMode.None;
                    break;
                case PlaceMode.HSubmarine:
                case PlaceMode.VSubmarine:
                    ship = new shipPlacement() { x = (m.X / 32) * 32, y = (m.Y / 32) * 32, placement = mode };
                    if (client.PlaceShip(uid, ship))
                    {
                        placements.Add(ship);
                        submarineBtn.Visible = false;
                    }
                    mode = PlaceMode.None;
                    break;
                case PlaceMode.HDestroyer:
                case PlaceMode.VDestroyer:
                    ship = new shipPlacement() { x = (m.X / 32) * 32, y = (m.Y / 32) * 32, placement = mode };
                    if (client.PlaceShip(uid, ship))
                    {
                        placements.Add(ship);
                        destroyerBtn.Visible = false;
                    }
                    mode = PlaceMode.None;
                    break;
                case PlaceMode.HBoat:
                case PlaceMode.VBoat:
                    ship = new shipPlacement() { x = (m.X / 32) * 32, y = (m.Y / 32) * 32, placement = mode };
                    if (client.PlaceShip(uid, ship))
                    {
                        placements.Add(ship);
                        boatBtn.Visible = false;
                    }
                    mode = PlaceMode.None;
                    break;
            }
            Draw();
            if (placements.Count >= 5)
            {
                shipPlacementGrp.Visible = false;
                startBtn.Enabled = true;
            }
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            startBtn.Enabled = false;
            mTitle.Text = "-Waiting for other player-";
            try
            {
                client.StartGame(uid);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                System.Diagnostics.Process.GetCurrentProcess().Kill();
            }
            gameStateUpdate.Start();
        }

        private void gameStateUpdate_Tick(object sender, EventArgs e)
        {
            try
            {
                string msg = client.GetPlayerInfo();
                string[] tmp = msg.Split(new char[] { '!' });
                playerinfo = new playerInfo();
                opponentinfo = new playerInfo();
                playerInfo tmpinfo = new playerInfo();
                foreach (string s in tmp)
                {
                    if (s != "")
                    {
                        string[] fields = s.Split(new char[] { ',' });
                        tmpinfo.uid = int.Parse(fields[0]);
                        tmpinfo.name = fields[1];
                        tmpinfo.board = new int[10, 10];
                        int f = 2;
                        for (int y = 0; y < 10; y++)
                        {
                            for (int x = 0; x < 10; x++)
                            {
                                tmpinfo.board[x, y] = int.Parse(fields[f++]);
                            }
                        }
                        tmpinfo.turn = bool.Parse(fields[f]);
                        if (uid == tmpinfo.uid)
                            playerinfo = tmpinfo;
                        else
                            opponentinfo = tmpinfo;
                    }
                    tmpinfo = new playerInfo();
                }

                if (playerinfo.turn)
                {
                    mTitle.Text = "-It is your turn-";
                    endBtn.Enabled = true;
                }
                else if (opponentinfo.turn)
                {
                    mTitle.Text = "-Waiting for opponent to end turn-";
                    endBtn.Enabled = false;
                }
                else
                    mTitle.Text = "-Waiting for an opponent-";

                opponentNameTxt.Text = opponentinfo.name;
                Draw();
            }
            catch (Exception ex)
            {
                gameStateUpdate.Stop();
                MessageBox.Show(ex.Message);
                System.Diagnostics.Process.GetCurrentProcess().Kill();
            }
        }

        private void opponentCanvas_Click(object sender, EventArgs e)
        {
            MouseEventArgs m = (MouseEventArgs)e;
            if (playerinfo.turn)
            {
                target[0] = m.X / 32; target[1] = m.Y / 32;
            }
            Draw();
        }

        private void endBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (playerinfo.turn)
                    if (client.Shoot(uid, target[0], target[1]))
                    {
                        endBtn.Enabled = false;
                        target[0] = -1; target[1] = -1;
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                System.Diagnostics.Process.GetCurrentProcess().Kill();
            }
        }

        public void Draw()
        {
            player.Clear(Color.LightCyan);
            opponent.Clear(Color.LightCyan);

            for (int x = 1; x < 10; x++)
            {
                for (int y = 1; y < 10; y++)
                {
                    player.DrawLine(Pens.Black, x * 32, 0, x * 32, 320);
                    opponent.DrawLine(Pens.Black, x * 32, 0, x * 32, 320);
                    player.DrawLine(Pens.Black, 0, y * 32, 320, y * 32);
                    opponent.DrawLine(Pens.Black, 0, y * 32, 320, y * 32);
                }
            }


            foreach (shipPlacement p in placements)
            {
                player.DrawImage(ships[(int)p.placement], p.x, p.y);
            }

            for (int x = 0; x < 10; x++)
            {
                for (int y = 0; y < 10; y++)
                {
                    if (opponentinfo.board != null && opponentinfo.board[x, y] == 5)
                        opponent.DrawImage(explosions[1], x * 32, y * 32);
                    else if (opponentinfo.board != null && opponentinfo.board[x, y] == 6)
                        opponent.DrawImage(explosions[0], x * 32, y * 32);
                    if (playerinfo.board != null && playerinfo.board[x, y] == 5)
                        player.DrawImage(explosions[1], x * 32, y * 32);
                    else if (playerinfo.board != null && playerinfo.board[x, y] == 6)
                        player.DrawImage(explosions[0], x * 32, y * 32);
                }
            }

            opponent.DrawEllipse(Pens.Red, target[0] * 32, target[1] * 32, 32, 32);
            opponent.DrawLine(Pens.Red, target[0] * 32 + 16, target[1] * 32, target[0] * 32 + 16, target[1] * 32 + 32);
            opponent.DrawLine(Pens.Red, target[0] * 32, target[1] * 32 + 16, target[0] * 32 + 32, target[1] * 32 + 16);
            playerCanvas.Refresh();
            opponentCanvas.Refresh();
        }

        public struct playerInfo
        {
            public int uid;
            public string name;
            public int[,] board;
            public bool turn;
            public override string ToString()
            {
                string msg = uid.ToString() + "," + name + ",";
                for (int y = 0; y < 10; y++)
                {
                    for (int x = 0; x < 10; x++)
                    {
                        msg += board[x, y].ToString() + ",";
                    }
                }
                msg += turn.ToString();
                return msg;
            }
        }
    }
}
