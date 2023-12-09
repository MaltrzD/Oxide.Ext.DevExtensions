namespace Oxide.Ext.DevExtensions
{
    //DevExtension initial class:)
    public static class DevExtensions
    {
        /// <summary>
        /// Создан как точка создания библиотеки
        /// </summary>
        /// <returns>строка с мемом</returns>
        public static string GetMeme()
        {
            string[] memes = new string[] { "карбон крут", "https://youtu.be/dQw4w9WgXcQ?si=ZkgNSrX8D5bR5LeV", "meme" };
            

            return memes.GetRandom();
        }
    }
}
