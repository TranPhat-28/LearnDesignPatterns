using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearnDesignPatterns
{
    public class Facade
    {
        protected WaterSubsystem _waterSubsystem;

        protected ElectricalSubsystem _electricalSubsystem;

        public Facade(WaterSubsystem waterSubsystem, ElectricalSubsystem electricalSubsystem)
        {
            this._waterSubsystem = waterSubsystem;

            this._electricalSubsystem = electricalSubsystem;
        }

        // The Facade's methods are convenient shortcuts to the sophisticated
        // functionality of the subsystems. However, clients get only to a
        // fraction of a subsystem's capabilities.
        public string FacadeModeA()
        {
            string result = "Facade startup operation:\n";

            result += this._waterSubsystem.StartUp();

            result += this._electricalSubsystem.StartUp();

            result += "Facade orders subsystems to perform the action:\n";

            result += this._waterSubsystem.ModeA();

            result += this._electricalSubsystem.ModeA();

            return result;
        }

        public string FacadeModeB()
        {
            string result = "Facade startup operation:\n";

            result += this._waterSubsystem.StartUp();

            result += this._electricalSubsystem.StartUp();

            result += "Facade orders subsystems to perform the action:\n";

            result += this._waterSubsystem.ModeB();

            result += this._electricalSubsystem.ModeB();

            return result;
        }

        public string FacadeShutdown()
        {
            string result = "Facade shutdown operation:\n";

            result += "Facade orders subsystems to perform the action:\n";

            result += this._waterSubsystem.ShutDown();

            result += this._electricalSubsystem.ShutDown();

            return result;
        }
    }

    // The Subsystem can accept requests either from the facade or client
    // directly. In any case, to the Subsystem, the Facade is yet another
    // client, and it's not a part of the Subsystem.
    public class WaterSubsystem
    {
        public string StartUp()
        {
            return "Water system: Started\n";
        }

        public string ModeA()
        {
            return "Water system: ModeA\n";
        }

        public string ModeB()
        {
            return "Water system: ModeB\n";
        }

        public string ShutDown()
        {
            return "Water system: Stopped\n";
        }
    }

    // Some facades can work with multiple subsystems at the same time.
    public class ElectricalSubsystem
    {
        public string StartUp()
        {
            return "Electrical system: Started\n";
        }

        public string ModeA()
        {
            return "Electrical system: ModeA\n";
        }

        public string ModeB()
        {
            return "Electrical system: ModeB\n";
        }

        public string ShutDown()
        {
            return "Water system: Stopped\n";
        }
    }

    // The client code works with complex subsystems through a simple
    // interface provided by the Facade. When a facade manages the lifecycle
    // of the subsystem, the client might not even know about the existence
    // of the subsystem. This approach lets you keep the complexity under
    // control.

    /* FACADE */
    // Facade facade = new Facade(new WaterSubsystem {}, new ElectricalSubsystem {});
    // Console.WriteLine(facade.FacadeModeA());
}