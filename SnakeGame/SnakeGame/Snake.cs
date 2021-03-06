using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SnakeGame
{
    public class Snake
    {
        SnakeParts[] snakeParts;                                    // yılanın gövde parçaları dizide tutuldu.
        int snakeSize;
        Direction direction1;
        Size size;


        public Snake(Size gameSize)
        {
            size = gameSize;
            snakeParts = new SnakeParts[3];                         // başlangıçta yılanın 3 parça olması sağlandı.
            snakeSize = 3;
            snakeParts[0] = new SnakeParts(150, 150);               // yılanın başlangıç konumu belirtildi -baş kısmı-.
            snakeParts[1] = new SnakeParts(160, 150);
            snakeParts[2] = new SnakeParts(170, 150);
        }


        // yılanın ilerlemesi ayarlandı.
        public void Go(Direction direction)
        {
            direction1 = direction;

            if (direction._x == 0 && direction._y == 0)
            {

            }
            else
            {
                // yılanın diğer parçalarına baş kısmı takip ettirildi.
                for (int i = snakeParts.Length - 1; i > 0; i--)                                     // hangi yöne gitmek isterse gidebilsin diye 0 dahil edilmedi.
                {
                    snakeParts[i] = new SnakeParts(snakeParts[i - 1].x_, snakeParts[i - 1].y_);
                }

                snakeParts[0] = new SnakeParts((snakeParts[0].x_ + direction._x) % size.Width, (snakeParts[0].y_ + direction._y) % size.Height);

                if (snakeParts[0].x_ < 0)
                {
                    snakeParts[0].x_ += size.Width;
                }
                if (snakeParts[0].y_ < 0)
                {
                    snakeParts[0].y_ += size.Height;
                }
            }
        }


        // yem yediğinde boyutu büyümesi için fonksiyon yazıldı.
        public void Grow()
        {
            Array.Resize(ref snakeParts, snakeParts.Length + 1);                                    // yılanın boyutu artırıldı.
            snakeParts[snakeParts.Length - 1] = new SnakeParts(snakeParts[snakeParts.Length - 2].x_ - direction1._x, snakeParts[snakeParts.Length - 2].y_ - direction1._y);
            snakeSize++;
        }


        // x ve y koordinatlarına göre yeni koordinatları belirten metod.
        public Point GetPos(int number)
        {
            return new Point(snakeParts[number].x_, snakeParts[number].y_);
        }


        // yılan büyüklüğü özelliği döndürüldü.
        public int SnakeSize
        {
            get
            {
                return snakeSize;
            }
        }
    }


    // yılan parçaları için class oluşturuldu.
    public class SnakeParts
    {
        public int x_;
        public int y_;
        public readonly int size_x;
        public readonly int size_y;


        // yılan parçaları için x ve y koordinatları belirtildi.
        public SnakeParts(int x, int y)
        {
            x_ = x;
            y_ = y;

            size_x = 10;
            size_y = 10;
        }
    }


    // yön için class oluşturuldu.
    public class Direction
    {
        public readonly int _x;
        public readonly int _y;


        // yön için x ve y koordinnatları atandı.
        public Direction(int x, int y)
        {
            _x = x;
            _y = y;
        }
    }
}
