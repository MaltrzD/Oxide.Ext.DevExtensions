using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oxide.Ext.DevExtensions
{
    public static class ListExtensions
    {
        public static string ToSentenceAdv<T>(this List<T> list)
        {
            StringBuilder sb = new StringBuilder();
            sb.Capacity = list.Count;

            sb.Append("[");

            foreach (var item in list)
                sb.Append($"{item}|");
            sb.Remove(sb.Length - 1, 1);

            sb.Append("]");


            return sb.ToString();
        }
    }
}
