using MyNoTetris.Classes;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MyNoTetris
{
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();
        }

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
        private int Score = 0;


        private void GameStart()
        {
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

            _gameTimer.Tick += timer_tick;
            _gameTimer.Interval = 200;
            _gameTimer.Start();
        }
        private ShapeBlocks getNexBlock()
        {
            var ShapeBlocks = GetRandomBlocks();
            _nextBlockBitmap = new Bitmap(6 * _pointsSize, 6 * _pointsSize);
            _nextBlockGraphics = Graphics.FromImage(_nextBlockBitmap);

            _nextBlockGraphics.FillRectangle(_backGroundColor,0,0, _nextBlockBitmap.Width, _nextBlockBitmap.Height);

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
            Score = 0;
            TXT_SCORE.Text = Score.ToString();
            TXT_LEVEL.Text = (Score / 10 + 1).ToString();
        _blockCurrentX = 0;
        _blockCurrentY = 0;

          _currentBlock =  new ShapeBlocks();

            _gameTimer.Stop();
            _gameTimer.Dispose();
             _gameTimer = new Timer();
          
    }
        private ShapeBlocks GetRandomBlocks()
        {
            var block = BlocksHandler.GetRandomBlock();
            _blockCurrentX = 7; /* divide ao meio e tenta colocar o bloco no meio */
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
                
                return true;
            }
            return false;
        }

        private void timer_tick(object sender, EventArgs e)
        {
            var moved = VerifyIfBlockCanMove(moveDown: 1);
            if (moved == false)
            {
                _gameAreaBitmap = new Bitmap(_threadBitmap);
                updateGameArea();
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
                for (y = _gameAreaWitdh -1; y >= 0; y--)
                {
                    if (_gameAreaPointsToARRAY[y, x] == 0)
                        break;
                }
                if (y == -1)
                {
                    Score++;
                    TXT_SCORE.Text = Score.ToString();
                    TXT_LEVEL.Text = (Score / 10 + 1).ToString();
                    _gameTimer.Interval -= 10;
                    for (y = 0; y < _gameAreaWitdh; y++)
                    {
                        for(int k = x; k > 0; k--)
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
                       _gameAreaPointsToARRAY[y,x] == 1 ? _blocksColor : _backGroundColor,
                       y * _pointsSize, x * _pointsSize, _pointsSize, _pointsSize );
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
            if (!MoveSuccess
                && keyData == Keys.Up)
                _currentBlock.rollBoack();
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(_gameTimer.Enabled == false)
            {
                _gameTimer.Enabled = true;
                _gameTimer.Start();
            }
            else
            {
                _gameTimer.Enabled = false;
                _gameTimer.Stop();
            }
        }
    }
}