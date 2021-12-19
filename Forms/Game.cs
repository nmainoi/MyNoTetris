using MyNoTetris.Classes;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MyNoTetris
{
    public partial class Game : Form
    {
        private Timer _PostLogin = new Timer();

        public Game()
        {
            InitializeComponent();
            _PostLogin.Tick += timerPostLogin_tick;
            _PostLogin.Interval = 1;
            _PostLogin.Start();
        }

        private static globalCommands Gc = new globalCommands();

        /* Codigo default que uso para costumizar a barra superior*/
        #region DragScreenOnMoveVars

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        #endregion DragScreenOnMoveVars

        /* Aqui define o plando de fundo do jogo, e tela de preview */
        private static Brush _backGroundColor = new SolidBrush(Color.FromArgb(255, (byte)33, (byte)33, (byte)33));
        private static Brush _blocksColor = new SolidBrush(Color.FromArgb(255, (byte)255, (byte)255, (byte)255));
        /* Definicoes da tela do jogo*/
        private Bitmap _nextBlockBitmap;
        private Graphics _nextBlockGraphics;
        private Graphics _gameAreGraphics;
        private Bitmap _gameAreaBitmap;

        private int _gameAreaWitdh = 14;
        private int _gameAreaHeight = 26;
        private int[,] _gameAreaPointsToARRAY;
        private int _pointsSize = 20;
        /* Atual valor X e Y do blocos*/
        private int _blockCurrentX;
        private int _blockCurrentY;
        /* Strtura do bloco*/
        private ShapeBlocks _currentBlock;
        private ShapeBlocks _netxBlock;
        /* Trhead  */
        private Bitmap _threadBitmap;
        private Graphics _threadGraphics;
        private Timer _gameTimer = new Timer();
        private int _score = 0;
        private bool _gameRuning = false;

        private void GameStart()
        {
            //  StartSong();

            ClearGame();
            PB_MAIN_GAME.Width = _gameAreaWitdh * _pointsSize;
            PB_MAIN_GAME.Height = _gameAreaHeight * _pointsSize;

            _gameAreaBitmap = new Bitmap(PB_MAIN_GAME.Width, PB_MAIN_GAME.Height);
            _gameAreGraphics = Graphics.FromImage(_gameAreaBitmap);
            _gameAreGraphics.FillRectangle(_backGroundColor, 0, 0, _gameAreaBitmap.Width, _gameAreaBitmap.Height);

            PB_MAIN_GAME.Image = _gameAreaBitmap;

            _gameAreaPointsToARRAY = new int[_gameAreaWitdh, _gameAreaHeight];

            _currentBlock = GetRandomBlocks();
            _netxBlock = getNexBlock();
            /* set timer */
            _gameTimer.Tick += timer_tick;
            _gameTimer.Interval = 200;
            GameChangeSatus();
        }

        private ShapeBlocks getNexBlock()
        {
            var ShapeBlocks = GetRandomBlocks();
            _nextBlockBitmap = new Bitmap(6 * _pointsSize, 6 * _pointsSize);
            _nextBlockGraphics = Graphics.FromImage(_nextBlockBitmap);

            _nextBlockGraphics.FillRectangle(_backGroundColor, 0, 0, _nextBlockBitmap.Width, _nextBlockBitmap.Height);

            var startX = (6 - ShapeBlocks._width) / 2;
            var startY = (6 - ShapeBlocks._height) / 2;

            for (int y = 0; y < ShapeBlocks._height; y++)
            {
                for (int x = 0; x < ShapeBlocks._width; x++)
                {
                    _nextBlockGraphics.FillRectangle(
                        ShapeBlocks._points[y, x] == 1 ? _blocksColor : _backGroundColor,
                        (startX + x) * _pointsSize, (startY + y) * _pointsSize, _pointsSize, _pointsSize
                        );
                }
            }
            PB_PREVIEW.Size = _nextBlockBitmap.Size;
            PB_PREVIEW.Image = _nextBlockBitmap;
            return ShapeBlocks;
        }

        private void ClearGame()
        {
            _score = 0;
            LBL_SCORE.Text = _score.ToString();
            LBL_LEVEL.Text = (_score / 10 + 1).ToString();
            _blockCurrentX = 0;
            _blockCurrentY = 0;

            _currentBlock = new ShapeBlocks();
            _gameRuning = false;
            _gameTimer.Stop();
            _gameTimer.Dispose();
            _gameTimer = new Timer();
        }

        private ShapeBlocks GetRandomBlocks()
        {
            var block = BlocksHandler.GetRandomBlock();
            int gameArea = _gameAreaWitdh;
            _blockCurrentX =  gameArea / 2; /* divide ao meio e tenta colocar o bloco no meio */
            _blockCurrentY = -block._height;
            return block;
        }

        private bool VerifyIfBlockCanMove(int moveDown = 0, int movside = 0)
        {
            var newX = _blockCurrentX + movside;
            var newY = _blockCurrentY + moveDown;
            /* Verifica se o bloco esta enconstado em uma das parades de o jogo */
            if (newX < 0
             || newX + _currentBlock._width > _gameAreaWitdh
             || newY + _currentBlock._height > _gameAreaHeight)
                return false;

            /* Verifica se esta inconstado em outros blocos*/
            for (int y = 0; y < _currentBlock._width; y++)
            {
                for (int x = 0; x < _currentBlock._height; x++)
                {
                    if (newY + x > 01
                        && _gameAreaPointsToARRAY[newX + y, newY + x] == 1
                        && _currentBlock._points[x, y] == 1)
                        return false;
                }
            }

            _blockCurrentX = newX;
            _blockCurrentY = newY;
            DrawBlock();

            return true;
        }

        private void DrawBlock()
        {
            _threadBitmap = new Bitmap(_gameAreaBitmap);
            _threadGraphics = Graphics.FromImage(_threadBitmap);
            for (int y = 0; y < _currentBlock._width; y++)
            {
                for (int x = 0; x < _currentBlock._height; x++)
                {
                    if (_currentBlock._points[x, y] == 1)
                        _threadGraphics.FillRectangle(_blocksColor, (_blockCurrentX + y) * _pointsSize, (_blockCurrentY + x) * _pointsSize, _pointsSize, _pointsSize);
                }
            }
            PB_MAIN_GAME.Image = _threadBitmap;
        }

        private void updateGameArea()
        {
            for (int y = 0; y < _currentBlock._width; y++)
            {
                for (int x = 0; x < _currentBlock._height; x++)
                {
                    if (_currentBlock._points[x, y] == 1)
                    {
                        if (checkGameOver())
                            return;
                        _gameAreaPointsToARRAY[_blockCurrentX + y, _blockCurrentY + x] = 1;
                    }
                }
            }
        }

        private bool checkGameOver()
        {
            if (_blockCurrentY < 0)
            {
                _gameTimer.Stop();
                MessageBox.Show("Fim de jogo!");
                UpdateScore();
                /* precisa colocar na hash caso seja novo usuario - TODO*/
                SQL.MakeUserHash();
                OpenRank(true);
                return true;
            }
            return false;
        }

        private static void OpenRank(bool gameOver)
        {
            MyNoTetris.Forms.ScoreBoard ScoreBoard = new MyNoTetris.Forms.ScoreBoard();
            ScoreBoard.CreateDataCrid(gameOver);
            ScoreBoard.ShowDialog();
        }

        private void UpdateScore()
        {
            string mysql = "Select ID FROM [BDTetris].[dbo].[USER](nolock) WHERE NAME= '" + SQL._user + "'";
            string UserHasName = Classes.SQL.ReadSQL(mysql);

            if (!string.IsNullOrEmpty(UserHasName))/* so insere novo usuario se nao le direto */
            {
                mysql = "INSERT INTO [BDTetris].[dbo].[SCORE] (ID,SCORE,DATE,TIME) VALUES ( ";
                mysql += SQL._id;
                mysql += "," + _score + "";
                mysql += ",'" + Gc.Format(DateTime.Now, "yyyyMMdd") + "'";
                mysql += ",'" + Gc.Format(DateTime.Now, "HH:mm") + "'";
                mysql += ")";
            }
            Classes.SQL.InsertSQL(mysql);
        }

        private void timerPostLogin_tick(object sender, EventArgs e)
        {
            _PostLogin.Stop();
            SQL.ConsistSQLDatabase();
            MyNoTetris.Forms.Login Login = new MyNoTetris.Forms.Login();
            Login.ShowDialog();

            Enabled = true;
            GameStart();
        }

        private void timer_tick(object sender, EventArgs e)
        {
            var moved = VerifyIfBlockCanMove(moveDown: 1);
            if (moved == false)
            {
                _gameAreaBitmap = new Bitmap(_threadBitmap);
                updateGameArea();
                _netxBlock = getNexBlock();
                _currentBlock = GetRandomBlocks();
                _netxBlock = getNexBlock();
                clearFillRow();
            }
        }

        private void clearFillRow()
        {
            for (int x = 0; x < _gameAreaHeight; x++)
            {
                int y;
                for (y = _gameAreaWitdh - 1; y >= 0; y--)
                {
                    if (_gameAreaPointsToARRAY[y, x] == 0)
                        break;
                }
                if (y == -1)
                {
                    _score++;
                    LBL_SCORE.Text = _score.ToString();
                    LBL_LEVEL.Text = (_score / 10 + 1).ToString();
                    _gameTimer.Interval -= 10;
                    for (y = 0; y < _gameAreaWitdh; y++)
                    {
                        for (int k = x; k > 0; k--)
                        {
                            _gameAreaPointsToARRAY[y, k] = _gameAreaPointsToARRAY[y, k - 1];
                        }
                        _gameAreaPointsToARRAY[y, 0] = 0;
                    }
                }
            }
            for (int y = 0; y < _gameAreaWitdh; y++)
            {
                for (int x = 0; x < _gameAreaHeight; x++)
                {
                    _gameAreGraphics = Graphics.FromImage(_gameAreaBitmap);
                    _gameAreGraphics.FillRectangle(
                        _gameAreaPointsToARRAY[y, x] == 1 ? _blocksColor : _backGroundColor,
                        y * _pointsSize, x * _pointsSize, _pointsSize, _pointsSize);
                }
            }
            PB_MAIN_GAME.Image = _gameAreaBitmap;
        }

        private void BT_START_Click(object sender, EventArgs e)
        {
            GameStart();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            var verticalMovemnt = 0;
            var horizontalMovemnt = 0;
            //capture up arrow key
            switch (keyData)
            {
                case Keys.Left:
                    verticalMovemnt--;
                    break;

                case Keys.Right:
                    verticalMovemnt++;
                    break;

                case Keys.Down:
                    horizontalMovemnt++;
                    break;

                case Keys.Up:
                    _currentBlock.turn();
                    break;

                default:
                    break;
            }
            var MoveSuccess = VerifyIfBlockCanMove(horizontalMovemnt, verticalMovemnt);
            if (MoveSuccess == false
                && keyData == Keys.Up)
                _currentBlock.rollBoack();
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GameChangeSatus();
        }

        private void GameChangeSatus()
        {
            if (_gameRuning == false)
            {
                BT_PAUSE.Text = "Pausar";
                _gameRuning = true;
                _gameTimer.Start();
            }
            else if (_gameRuning)
            {
                BT_PAUSE.Text = "Continuar";
                _gameRuning = false;
                _gameTimer.Stop();
            }
        }
        private void MoveScreenOnMouseDrag(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        private void BT_RANKING_Click(object sender, EventArgs e)
        {
            GameChangeSatus();
            OpenRank(false);       
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            MoveScreenOnMouseDrag(e);
        }

        private void label3_MouseDown(object sender, MouseEventArgs e)
        {
            MoveScreenOnMouseDrag(e);
        }

        private void BT_CLOSE_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BT_MINIZE_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Game_Leave(object sender, EventArgs e)
        {
        
        }
    }
}