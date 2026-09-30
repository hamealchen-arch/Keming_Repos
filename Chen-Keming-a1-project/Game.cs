// Include the namespaces (code libraries) you need below.
using System;
using System.ComponentModel;
using System.Numerics;

// The namespace your code is in.
namespace MohawkGame2D
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetTitle("First Program");
            Window.SetSize(400, 400);
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground(85); //medium grey background
            //initializes colours, the variable names are the colours if the user isn't pressing any keys
            int blue1 = 255;
            int blue2 = 255;
            int blue3 = 255;

            int yellow1 = 0;
            int yellow2 = 0;
            int yellow3 = 0;

            if (Input.IsKeyboardKeyDown(KeyboardKey.Space) == true && Input.IsKeyboardKeyDown(KeyboardKey.G) == false && Input.IsKeyboardKeyDown(KeyboardKey.R) == false)
            {   // Inverts colours, IF holding space bar
                yellow1 = 33;
                yellow2 = 33;
                yellow3 = 177;

                blue1 = 229;
                blue2 = 199;
                blue3 = 55;
            }
            else if (Input.IsKeyboardKeyDown(KeyboardKey.Space) == false && Input.IsKeyboardKeyDown(KeyboardKey.G) == false && Input.IsKeyboardKeyDown(KeyboardKey.R) == false)
            {   // flag remains normal colour when no key is being held down
                blue1 = 33;
                blue2 = 33;
                blue3 = 177;

                yellow1 = 229;
                yellow2 = 199;
                yellow3 = 55;
            }
            else if (Input.IsKeyboardKeyDown(KeyboardKey.Space) == false && Input.IsKeyboardKeyDown(KeyboardKey.G) == true && Input.IsKeyboardKeyDown(KeyboardKey.R) == false)
            {   //parts of the flag become Green & Black when 'G' is being held
                blue1 = 0;
                blue2 = 255;
                blue3 = 0;

                yellow1 = 0;
                yellow2 = 0;
                yellow3 = 0;
            }
            else if (Input.IsKeyboardKeyDown(KeyboardKey.Space) == true && Input.IsKeyboardKeyDown(KeyboardKey.G) == true && Input.IsKeyboardKeyDown(KeyboardKey.R) == false)
            {   //parts of the flag become Black & Green when 'G' AND 'spacebar' is being held
                blue1 = 0;
                blue2 = 0;
                blue3 = 0;

                yellow1 = 0;
                yellow2 = 255;
                yellow3 = 0;
            }
            else if (Input.IsKeyboardKeyDown(KeyboardKey.Space) == false && Input.IsKeyboardKeyDown(KeyboardKey.G) == false && Input.IsKeyboardKeyDown(KeyboardKey.R) == true)
            {  //parts of the flag become Red & Black when 'R' is being held
                blue1 = 255;
                blue2 = 0;
                blue3 = 0;

                yellow1 = 0;
                yellow2 = 0;
                yellow3 = 0;
            }
            else if (Input.IsKeyboardKeyDown(KeyboardKey.Space) == true && Input.IsKeyboardKeyDown(KeyboardKey.G) == false && Input.IsKeyboardKeyDown(KeyboardKey.R) == true)
            {  //parts of the flag become Black & Red when 'R' AND 'spacebar' is being held
                blue1 = 0;
                blue2 = 0;
                blue3 = 0;

                yellow1 = 255;
                yellow2 = 0;
                yellow3 = 0;
            }
            else if (Input.IsKeyboardKeyDown(KeyboardKey.Space) == true && Input.IsKeyboardKeyDown(KeyboardKey.G) == true && Input.IsKeyboardKeyDown(KeyboardKey.R) == true)
            {  //parts of the flag become Black & White when both all keys are being held
                blue1 = 0;
                blue2 = 0;
                blue3 = 0;

                yellow1 = 255;
                yellow2 = 255;
                yellow3 = 255;
            }
            //By virtue of how the variables were intialized, if none of these 'if/else-if' statements are met (both 'R' and 'G' are being held but NOT 'spacebar')...
            //...Then the flag defaults to White & Black

            


            Draw.SetLineSize(0); //default line size
            Draw.SetFillColor(blue1, blue2, blue3); //sets the square to blue
            Draw.Square(120, 120, 160); //middle blue part of mock-hamilton flag


            Draw.SetFillColor(yellow1, yellow2, yellow3); //sets the sides to yellow
            Draw.Rectangle(40, 120, 80, 160); //left yellow part of mock-hamilton flag
            Draw.Rectangle(280, 120, 80, 160); //right yellow part of mock-hamilton flag
            


            Draw.SetLineSize(5); //prepares the hexagon's outline
            Draw.SetLineColor(yellow1, yellow2, yellow3); //colours the hexagon's line to yellow
            Draw.SetFillColor(blue1, blue2, blue3); //makes the hexagon blue so only the outline stands out
            Draw.Polygon(200, 200, 60, 6, 90, PolygoneMode.InsideRadius); //draws the hexagon (yellow outline, blue)


            Draw.SetFillColor(yellow1, yellow2, yellow3); //sets the circle to yellow
            Draw.Circle(200, 200, 30); //draws a yellow circle at the centre of the screen



            //leftover cut content
            //Draw.SetLineSize(5);
            //Draw.PolyLine([200, 140], [140, 200]);
            //Draw.PolyLine(int[x], int[y]);
            //Draw.shape(positions, sizes);







        }
    }

}
