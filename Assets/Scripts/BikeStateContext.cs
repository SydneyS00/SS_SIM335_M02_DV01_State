using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Chapter.State
{
    public class BikeStateContext
    {
        public IBikeState CurrentState
        {
            get;
            set;
        }

        private readonly BikeController _bikeController;

        //This exposes a public property that points to the current
        //  state of the bike. That makes it aware of any state change.
        public BikeStateContext(BikeController bikeController)
        {
            _bikeController = bikeController;
        }

        //We call this method in order to update the current state
        //  of our entity through its property and transition
        public void Transition()
        {
            CurrentState.Handle(_bikeController);
        }

        public void Transition(IBikeState state)
        {
            CurrentState = state;
            CurrentState.Handle(_bikeController);
        }


    }
}
