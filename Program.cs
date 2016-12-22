using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Media;

namespace Pinball
{
    class Program
    {
        static void Main(string[] args)
        {
            bool pinball = true;//execucao do jogo
            System.Diagnostics.Process.Start("musica0.mp3");
            do
            {
                Console.WriteLine("Pressione uma tecla de A a Z para algum efeito sonoro\nOu os numeros de 0 a 9 para musicas...");
                ConsoleKey teclaPressionada = Console.ReadKey().Key;
                switch (teclaPressionada)
                {
                    #region letras de A a Z
                    case ConsoleKey.A:
                        Console.Clear();
                        using (SoundPlayer player = new SoundPlayer("fxA.wav"))
                            player.Play();
                        break;
                    case ConsoleKey.B:
                        Console.Clear();
                        using (SoundPlayer player = new SoundPlayer("fxB.wav"))
                            player.Play();
                        break;
                    case ConsoleKey.C:
                        Console.Clear();
                        using (SoundPlayer player = new SoundPlayer("fxC.wav"))
                            player.Play();
                        break;
                    case ConsoleKey.D:
                        Console.Clear();
                        using (SoundPlayer player = new SoundPlayer("fxD.wav"))
                            player.Play();
                        break;
                    case ConsoleKey.E:
                        Console.Clear();
                        using (SoundPlayer player = new SoundPlayer("fxE.wav"))
                            player.Play();
                        break;
                    case ConsoleKey.F:
                        Console.Clear();
                        using (SoundPlayer player = new SoundPlayer("fxF.wav"))
                            player.Play();
                        break;
                    case ConsoleKey.G:
                        Console.Clear();
                        using (SoundPlayer player = new SoundPlayer("fxG.wav"))
                            player.Play();
                        break;
                    case ConsoleKey.H:
                        Console.Clear();
                        using (SoundPlayer player = new SoundPlayer("fxH.wav"))
                            player.Play();
                        break;
                    case ConsoleKey.I:
                        Console.Clear();
                        using (SoundPlayer player = new SoundPlayer("fxI.wav"))
                            player.Play();
                        break;
                    case ConsoleKey.J:
                        Console.Clear();
                        using (SoundPlayer player = new SoundPlayer("fxJ.wav"))
                            player.Play();
                        break;
                    case ConsoleKey.K:
                        Console.Clear();
                        using (SoundPlayer player = new SoundPlayer("fxK.wav"))
                            player.Play();
                        break;
                    case ConsoleKey.L:
                        Console.Clear();
                        using (SoundPlayer player = new SoundPlayer("fxL.wav"))
                            player.Play();
                        break;
                    case ConsoleKey.M:
                        Console.Clear();
                        using (SoundPlayer player = new SoundPlayer("fxM.wav"))
                            player.Play();
                        break;
                    case ConsoleKey.N:
                        Console.Clear();
                        using (SoundPlayer player = new SoundPlayer("fxN.wav"))
                            player.Play();
                        break;
                    case ConsoleKey.O:
                        Console.Clear();
                        using (SoundPlayer player = new SoundPlayer("fxO.wav"))
                            player.Play();
                        break;
                    case ConsoleKey.P:
                        Console.Clear();
                        using (SoundPlayer player = new SoundPlayer("fxP.wav"))
                            player.Play();
                        break;
                    case ConsoleKey.Q:
                        Console.Clear();
                        using (SoundPlayer player = new SoundPlayer("fxQ.wav"))
                            player.Play();
                        break;
                    case ConsoleKey.R:
                        Console.Clear();
                        using (SoundPlayer player = new SoundPlayer("fxR.wav"))
                            player.Play();
                        break;
                    case ConsoleKey.S:
                        Console.Clear();
                        using (SoundPlayer player = new SoundPlayer("fxS.wav"))
                            player.Play();
                        break;
                    case ConsoleKey.T:
                        Console.Clear();
                        using (SoundPlayer player = new SoundPlayer("fxT.wav"))
                            player.Play();
                        break;
                    case ConsoleKey.U:
                        Console.Clear();
                        using (SoundPlayer player = new SoundPlayer("fxU.wav"))
                            player.Play();
                        break;
                    case ConsoleKey.V:
                        Console.Clear();
                        using (SoundPlayer player = new SoundPlayer("fxV.wav"))
                            player.Play();
                        break;
                    case ConsoleKey.X:
                        Console.Clear();
                        using (SoundPlayer player = new SoundPlayer("fxX.wav"))
                            player.Play();
                        break;
                    case ConsoleKey.Z:
                        Console.Clear();
                        using (SoundPlayer player = new SoundPlayer("fxZ.wav"))
                            player.Play();
                        break;
                    case ConsoleKey.Y:
                        Console.Clear();
                        using (SoundPlayer player = new SoundPlayer("fxY.wav"))
                            player.Play();
                        break;
                    case ConsoleKey.W:
                        Console.Clear();
                        using (SoundPlayer player = new SoundPlayer("fxW.wav"))
                            player.Play();
                        break;
                    #endregion
                    #region numeros de 0 a 9
                    case ConsoleKey.D0:
                        Console.Clear();
                        System.Diagnostics.Process.Start("musica0.mp3");
                        break;
                    case ConsoleKey.D1:
                        Console.Clear();
                        System.Diagnostics.Process.Start("musica1.mp3");
                        break;
                    case ConsoleKey.D2:
                        Console.Clear();
                        System.Diagnostics.Process.Start("musica2.mp3");
                        break;
                    case ConsoleKey.D3:
                        Console.Clear();
                        System.Diagnostics.Process.Start("musica3.mp3");
                        break;
                    case ConsoleKey.D4:
                        Console.Clear();
                        System.Diagnostics.Process.Start("musica4.mp3");
                        break;
                    case ConsoleKey.D5:
                        Console.Clear();
                        System.Diagnostics.Process.Start("musica5.mp3");
                        break;
                    case ConsoleKey.D6:
                        Console.Clear();
                        System.Diagnostics.Process.Start("musica6.mp3");
                        break;
                    case ConsoleKey.D7:
                        Console.Clear();
                        System.Diagnostics.Process.Start("musica7.mp3");
                        break;
                    case ConsoleKey.D8:
                        Console.Clear();
                        System.Diagnostics.Process.Start("musica8.mp3");
                        break;
                    case ConsoleKey.D9:
                        Console.Clear();
                        System.Diagnostics.Process.Start("musica9.mp3");
                        break;
                    #endregion
                    #region numpad de 0 a 9
                    case ConsoleKey.NumPad0:
                        Console.Clear();
                        System.Diagnostics.Process.Start("musica0.mp3");
                        break;
                    case ConsoleKey.NumPad1:
                        Console.Clear();
                        System.Diagnostics.Process.Start("musica1.mp3");
                        break;
                    case ConsoleKey.NumPad2:
                        Console.Clear();
                        System.Diagnostics.Process.Start("musica2.mp3");
                        break;
                    case ConsoleKey.NumPad3:
                        Console.Clear();
                        System.Diagnostics.Process.Start("musica3.mp3");
                        break;
                    case ConsoleKey.NumPad4:
                        Console.Clear();
                        System.Diagnostics.Process.Start("musica4.mp3");
                        break;
                    case ConsoleKey.NumPad5:
                        Console.Clear();
                        System.Diagnostics.Process.Start("musica5.mp3");
                        break;
                    case ConsoleKey.NumPad6:
                        Console.Clear();
                        System.Diagnostics.Process.Start("musica6.mp3");
                        break;
                    case ConsoleKey.NumPad7:
                        Console.Clear();
                        System.Diagnostics.Process.Start("musica7.mp3");
                        break;
                    case ConsoleKey.NumPad8:
                        Console.Clear();
                        System.Diagnostics.Process.Start("musica8.mp3");
                        break;
                    case ConsoleKey.NumPad9:
                        Console.Clear();
                        System.Diagnostics.Process.Start("musica9.mp3");
                        break;
                    #endregion
                    case ConsoleKey.Escape:
                        Console.Clear();
                        pinball = false;
                        break;
                    default:
                        Console.Clear();
                        break;
                }
            } while (pinball);
        }
    }
}
