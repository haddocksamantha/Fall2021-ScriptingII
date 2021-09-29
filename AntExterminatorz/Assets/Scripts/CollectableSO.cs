/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class CollectableSO : ScriptableObject
{//learned from scripting II class
   public List<CollectableSO> collection;

   public void Collect(CollectableSO obj)
   {
      collection.Add(obj);
      obj.collected = true;
   }

   public void Remove(CollectableSO obj)
   {
      foreach (var collectable in collection.Where(collectable => collectable == obj))
      {
         collectable.collected = false;
         collection.Remove(collectable);
      }
   }

   public void Clear()
   {
      foreach (var collectable in collection)
      {
         collectable.collected = false;
      }
      collection.Clear();
   }
}
*/
