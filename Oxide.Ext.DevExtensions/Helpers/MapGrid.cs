using UnityEngine;

namespace Oxide.Ext.DevExtensions.Helpers
{
    /// <summary>
    /// Provides the ability to work with the map in a convenient format
    /// </summary>
    public class MapGrid
    {
        private Dictionary<string, Vector3> Grids = new Dictionary<string, Vector3>();

        private void BuildGrid(float worldSize)
        {
            Grids.Clear();
            float offset = worldSize / 2;
            var gridWidth = (0.0066666666666667f * worldSize);
            float step = worldSize / gridWidth;

            string start = "";

            char letter = 'A';
            int number = 0;

            for (float zz = offset; zz > -offset; zz -= step)
            {
                for (float xx = -offset; xx < offset; xx += step)
                {
                    Grids.Add($"{start}{letter}{number}", new Vector3(xx - 55f, 0, zz + 20f));
                    if (letter.ToString().ToUpper() == "Z")
                    {
                        start = "A";
                        letter = 'A';
                    }
                    else
                    {
                        letter = (char)(((int)letter) + 1);
                    }


                }
                number++;
                start = "";
                letter = 'A';
            }
        }

        /// <summary>
        /// Pass the player's position and get the square in which he is located.
        /// </summary>
        /// <param name="pos"></param>
        /// <returns>Name of square by position</returns>
        public string GetSquareName(Vector3 pos) => Grids.Where(x => x.Value.x < pos.x && x.Value.x + 150f > pos.x && x.Value.z > pos.z && x.Value.z - 150f < pos.z).FirstOrDefault().Key;

        /// <summary>
        /// Pass ConVar.Server.worldsize or other world size to generate grid
        /// </summary>
        /// <param name="worldSize"></param>
        public MapGrid(float worldSize)
        {
            BuildGrid(worldSize);
        }
    }
}
