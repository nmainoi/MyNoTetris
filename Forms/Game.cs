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
        private static Brush _backGroundColor = new SolidBrush(Color.FromArgb(255, (byte)43, (byte)43, (byte)43));
        private static Brush _blocksColor = new SolidBrush(Color.FromArgb(255, (byte)123, (byte)123, (byte)43));
        /* Definicoes da tela do jogo*/
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
        /* Trhead  */
        private Bitmap _threadBitmap;
        private Graphics _threadGraphics;
        private Timer _gameTimer = new Timer();

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
       
            _gameTimer.Tick += timer_tick;
            _gameTimer.Interval = 200;
            _gameTimer.Start();
        }
        private void ClearGame()
        {

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
            }
        }

        private void BT_START_Click(object sender, EventArgs e)
        {
            GameStart();
        }
    }
}