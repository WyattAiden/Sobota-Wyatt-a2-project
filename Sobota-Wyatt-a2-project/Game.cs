using Game10003;
using Raylib_cs;
using System;
using System.Drawing;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Numerics;

// The namespace your code is in.
namespace Game10003
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    
    public class Game
    {
        // Place your variables here:
         Color mauveine = new Color(138,109,139);
        //Color Vermillion = new Color(255, 87, 51);
        
        //making the array
        int[] array = new int[5];
        
        string[] History = [
            "Purple as the royal color started with ancient monarchies. \nThe color was difficult to produce, which made it expensive and available only to upper society. \nRulers wore purple robes and used purple ink to sign their edicts. \nSome Roman emperors penalized their citizens by death for wearing purple garments.\n",
            "Vermillion became popular in the Renaissance era, but ended up being too toxic and expensive.\nIt was derived from cinnabar, found in oxidized mercury.This shade can still be purchased today, \nbut it’s derived from safer materials.\n",
            "Ultramarine is a vivid deep blue color with the hex code #0437F2, one of numerous blue shades originally made from crushed lapis lazuli. Ultramarine pigment was favored during the Renaissance period, especially for painting the Virgin Mary’s robes.\n",
            "The color ebony is a representation of the color of the wood ebony, a tropical hardwood widely used to make fine furniture, notably for French kings.\nThe first use of ebony as a color name in English was in 1590.\n",
            "The web color gold is sometimes referred to as golden to distinguish it from the color metallic gold. The use of gold as a color term in traditional usage is more often applied to the color \"metallic gold\" (shown below).\nThe first recorded use of golden as a color name in English was in 1300 to refer to the element gold. The word gold as a color name was first used in 1400 and in 1423 to refer to blond hair.\n",
            "Apple green is a representation of the color of the outer skin of a Granny Smith apple. A darker version of this color has been used for the IRT Lexington Avenue Line since June 1979, when the NYCTA decided to assign line colors to all the routes within the major trunk lines in the Central Business District, plus different colors for services not entering Manhattan. By doing this, they scrapped the 1967 colors that were assigned separately to each service.\nThe first recorded use of apple green as a color name in English was in 1648.\n"
            ];
           //making the colors
        Color[] colors = [
            new Color(120,81,169), //this is purple
            new Color(255, 87, 51),//this is Vermillion
            new Color(4, 55, 242),//this is Ultramarine
            new Color(85, 93, 80),//this is Ebony
            new Color(255, 215, 0),//this is Gold
            new Color(138, 184, 0)//this is Apple green
            ];
        float[] X = [300,400,500,700,200,50];
        float[] Y = [200,50,500,300,500,150];



        public void Setup()
        {
            Window.SetTitle("colour finder");
            Window.SetSize(800, 600);

        }
        public void Update()
        {
            //window set up
            Window.ClearBackground(mauveine);

            for (int i = 0; i < 6; i++)
            {
                DrawCircle(X[i], Y[i], colors[i], History[i]);
            }
        }
        //drawing the circles
        void DrawCircle(float circleX, float circleY, Color circleColor, string circleHistory)
        {
            // we are not using circleX and circleY YET
            // ... how can we use those numbers below?
            float x = Input.GetMouseX();
            float y = Input.GetMouseY();
            //using the mouse to find the circle 
            if (x >=  circleX - 50 && x <= circleX + 50 && y >= circleY - 50 && y <= circleY + 50)
            {
                Draw.FillColor = circleColor;
                if (Input.IsMouseButtonPressed(MouseInput.Left))
                {
                    Console.WriteLine(circleHistory);
                }
            }
            else
            {
                Draw.FillColor = mauveine;
                Draw.LineColor = mauveine;
            }
            Draw.Circle(circleX,circleY,50);
        }


    }
}
