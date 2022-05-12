using System;
using System.IO;

namespace PrimeNumbers
{
    public class Writer
    {
        public Writer()
        {
        }

        public void WriteToConsole(int[,] matrix, int mLength)
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

        public void WriteToFile(int[,] matrix)
        {
            string data = @"<style>table, td {
            border: 1px solid black;
            }
            </style>"
            ;
            string table = string.Empty;

            data += "<div class=\"tab-content\">";

            table = " <table class=\"table data-table\">";
            table += "<tbody>";
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                table += "<tr>";
                for (int column = 0; column < matrix.GetLength(1); column++)
                {
                    try
                    {
                        if (matrix[row, column] == 0)
                        {
                            table += "<td></td>";
                        }
                        else
                        {
                            table += "<td>" + matrix[row, column].ToString() + "</td>";
                        }

                    }
                    catch
                    {
                        table += "<td></td>";
                    }
                }
                table += "</tr>";
            }
            table += "</tbody>";

            table += "</table>";

            data += table;
            data += "</div>";

            File.WriteAllText("Matrix.htm", data);
        }
    }
}
