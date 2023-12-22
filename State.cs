using System;

namespace LearnDesignPatterns
{
    // Context
    class TrafficLight
    {
        private TrafficLightState _state;

        public TrafficLight()
        {
            // Initial state is Red
            _state = new RedState();
        }

        public void ChangeState()
        {
            _state.StateUpdate(this);
        }

        public void SetState(TrafficLightState state)
        {
            _state = state;
        }

        public void ShowCurrentState()
        {
            Console.WriteLine($"Current state: {_state}");
        }
    }

    // State interface
    interface TrafficLightState
    {
        void StateUpdate(TrafficLight trafficLight);
    }

    // Concrete State: Red
    class RedState : TrafficLightState
    {
        public void StateUpdate(TrafficLight trafficLight)
        {
            Console.WriteLine("Changing to Yellow");
            trafficLight.SetState(new YellowState());
        }

        public override string ToString()
        {
            return "Red";
        }
    }

    // Concrete State: Yellow
    class YellowState : TrafficLightState
    {
        public void StateUpdate(TrafficLight trafficLight)
        {
            Console.WriteLine("Changing to Green");
            trafficLight.SetState(new GreenState());
        }

        public override string ToString()
        {
            return "Yellow";
        }
    }

    // Concrete State: Green
    class GreenState : TrafficLightState
    {
        public void StateUpdate(TrafficLight trafficLight)
        {
            Console.WriteLine("Changing to Red");
            trafficLight.SetState(new RedState());
        }

        public override string ToString()
        {
            return "Green";
        }
    }
}