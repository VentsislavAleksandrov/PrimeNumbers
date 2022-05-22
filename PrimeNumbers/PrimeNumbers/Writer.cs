using PrimeNumbers.Contracts;
using System;
using System.IO;
using System.Text;

namespace PrimeNumbers
{
    public class Writer:IConsoleWriter,IFileWriter
    {
        public Writer()
        {
        }

        public void WriteToConsole(int[,] matrix, int mLength)
        {
            ConsoleWrite(matrix, mLength);
        }

        public void WriteToFile(int[,] matrix)
        {
            FileWrite(matrix);
        }

        private void FileWrite(int[,] matrix)
        {
            string data = @"<style>table, td {
            border: 1px solid black;
            }
            </style>"
            ;
            var table = new StringBuilder();

            data += "<div class=\"tab-content\">";

            table.Append(" <table class=\"table data-table\">");
            table.Append("<tbody>");
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                table.Append("<tr>");
                for (int column = 0; column < matrix.GetLength(1); column++)
                {
                    try
                    {
                        if (matrix[row, column] == 0)
                        {
                            table.Append("<td> </td>");
                        }
                        else
                        {
                            table.Append("<td>" + matrix[row, column].ToString() + "</td>");
                        }

                    }
                    catch
                    {
                        table.Append("<td></td>");
                    }
                }
                table.Append("</tr>");
            }
            table.Append("</tbody>");

            table.Append("</table>");

            data += table;
            data += "</div>";

            File.WriteAllText("Matrix.htm", data);
        }

        private void ConsoleWrite(int[,] matrix, int mLength)
        {
            for (int i = 0; i < mLength; i++)
            {
                for (int j = 0; j < mLength; j++)
                {
                    if (matrix[i, j] == 0)
                    {
                        Console.Write("\t");
                    }
                    else
                    {
                        Console.Write($"{matrix[i, j]}\t");
                    }
                }

                Console.WriteLine();
            }
        }
    }
}
