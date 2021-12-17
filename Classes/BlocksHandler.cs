using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNoTetris.Classes
{
    static class BlocksHandler
    {
        private static ShapeBlocks[] BlocksArray;

        static BlocksHandler()
        {
            BlocksArray = new ShapeBlocks[]
            {
                new ShapeBlocks
                {
                    _width = 1,
                    _height = 4,
                    _blockName = "Linha",
                    _points = new int[,]
                    {
                        {1 },
                        {1 },
                        {1 },
                        {1 }
                    }
                }
            };
        }


        public static ShapeBlocks GetRandomBlock()
        {
            var block = BlocksArray[new Random().Next(BlocksArray.Length)];
                return block;
        }
    }
}
