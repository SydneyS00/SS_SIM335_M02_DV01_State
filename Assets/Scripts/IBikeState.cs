using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Chapter.State
{
    public interface IBikeState
    {
        //We are passing an instance of BikeController in the Handle() method.
        //  This permits state classes to access public properties of 
        //  BikeController.
        void Handle(BikeController controller);
    }
   
}
