using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace ThanhDev
{
    public class Thanh_LevelManagerGame2 : MonoBehaviour
    {
        #region Game2 - Sort The Apps

        [Header("Game2 - Sort The Apps")]

        [SerializeField] Thanh_Album[] albums;
        //[SerializeField] Thanh_DraggableItem[] draggableItems;

        [SerializeField] private List<Thanh_AlbumHolder> items;

        [SerializeField] private Thanh_DraggableItem draggableItemPrefabs;

        [SerializeField] private AppTextTureSO appTextTureSO;

        private int NumberOfApps;

        private void Start()
        {
            NumberOfApps = 12;

            for(int i=0; i<albums.Length; i++)
            {
                for(int j=0; j < albums[i].holder.Length; j++)
                {
                    items.Add(albums[i].holder[j]);
                }
            }

            

            for(int i= 0;i<NumberOfApps; i++)
            {
                int randomValue = Random.Range(0, items.Count);
                Thanh_AlbumHolder holder = items[randomValue];
                items.RemoveAt(randomValue);

                Thanh_DraggableItem item = Instantiate(draggableItemPrefabs, holder.transform);

                item.SetParent(holder.transform, holder);
                item.SetApp(appTextTureSO.GetApp());

                holder.SetAlbumOnDrop(item);

                
            }
        }





        #endregion
    }
}
