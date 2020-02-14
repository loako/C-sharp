//Anton Brottare 28/11-2017
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class ItemManager
    {


        private List<ShoppingItem> itemList;

        public ItemManager()
        {
            itemList = new List<ShoppingItem>();
        }

        public ShoppingItem GetItem(int index)
        {
            if (!CheckIndex(index))
            {
                return null;
            }
            return itemList[index];
        }

        public int Count()
        {
            return itemList.Count;
        }

        public bool AddItem (ShoppingItem itemIn)
        {
            bool ok = false;
            if(itemIn != null)
            {
                itemList.Add(itemIn);
                ok = true;
            }
            return ok;
        }

        private bool CheckIndex (int index)
        {
            return (index >=0) && (index < itemList.Count);
        }

        public string[] GetItemsInfoStrings()
        {
            string[] stringInfoStrings = new string[itemList.Count];
            int i = 0;
            foreach(ShoppingItem Itemobj in itemList)
            {
                stringInfoStrings[i++] = Itemobj.ToString();
            }
            return stringInfoStrings;
        } 


    }
}
