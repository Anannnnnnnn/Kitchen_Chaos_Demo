using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearCounter : BaseCounter
{

    [SerializeField] private KitchenObjectSO kitchenObjectSO;
   


    public override void Interact(Player player)
    {
        if (!HasKitchenObject())
        {
            //There is no KitchenObject here
            if (player.HasKitchenObject())
            {
                //Player is carrying something
                player.GetKitchenObject().SetKitchenObjectParent(this);
            }
            else
            {
                //Player is not carrying anything
            }

        }
        else
        {
            //There is a KitchenObject here
            if(player.HasKitchenObject())
            {
                //Player is carrying something
                if(player.GetKitchenObject().TryGetplate(out PlateKitchenObject plateKitchenObject))
                {
                    //Player is holding a plate
                    
                    if (plateKitchenObject.TryAddIngredient(GetKitchenObject().GetKitchenObjectSO()))
                    {
                        GetKitchenObject().DestroySelf();
                    }

                }
                else
                {
                    //Player is not holding a plate but something else 
                    if(GetKitchenObject().TryGetplate(out plateKitchenObject))//If there's a plate on the clearcounter
                    {
                        //Counter is holding a plate
                        if (plateKitchenObject.TryAddIngredient(player.GetKitchenObject().GetKitchenObjectSO()))
                        {
                            //Put the food on the plate and destroy the held one
                            player.GetKitchenObject().DestroySelf();
                        }
                    }


                }
            }
            else
            {
                //Player is not carrying anything
                GetKitchenObject().SetKitchenObjectParent(player);
            }
        }

    }

   

}
