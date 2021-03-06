namespace MyNoTetris.Classes
{
    internal class ShapeBlocks
    {
        public int _width;
        public int _height;
        public int[,] _points;
        public string _blockName;
        public int[,] _backupPoints;

        public void turn()
        {
            _backupPoints = _points;

            _points = new int[_width, _height];

            for (int y = 0; y < _width; y++)
            {
                for (int x = 0; x < _height; x++)
                {
                    _points[y, x] = _backupPoints[_height - 1 - x, y];
                }
            }
            /* Inverte posicoes poes loop para fazer o turn*/
            var tempWitdh = _width;
            _width = _height;
            _height = tempWitdh;
        }

        public void rollBoack()
        {
            /* Retorna antiga posicao*/
            _points = _backupPoints;
            var tempWitdh = _width;
            _width = _height;
            _height = tempWitdh;
        }
    }
}