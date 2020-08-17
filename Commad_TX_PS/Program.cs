using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using Tecnomatix.Engineering;
using Tecnomatix.Engineering.Ui;


namespace Commad_TX_PS
{
    //[EditorBrowsable(EditorBrowsableState.Advanced)]
    //public static ResourceManager ResourceManager { get; }
    public class MyCommand : TxButtonCommand
    {
        public MyCommand()
        {
        }
        public override void Execute(System.Object cmdParams)
        {
            // The command logic
        }
        public override string Name
        {
            get
            {
                ResourceManager resourceMgr = new ResourceManager("EngineeringCommands.StringTable", this.GetType().Assembly);
                return resourceMgr.GetString("CMD_NAME");
            }
        }
        public override string Category
        {
            get
            {
                ResourceManager resourceMgr = new ResourceManager("EngineeringCommands.StringTable", this.GetType().Assembly);
                return resourceMgr.GetString("CMD_CATEGORY");
            }
        }
    }

    public class CommandResource : ITxButtonCommandResources, ITxCommand
    {
        public string Name => throw new NotImplementedException();

        public string Tooltip => throw new NotImplementedException();

        public string Description => throw new NotImplementedException();

        public string Category => throw new NotImplementedException();

        public string Bitmap => throw new NotImplementedException();

        public ITxCommandEnabler CommandEnabler => throw new NotImplementedException();

        public bool Connect()
        {
            throw new NotImplementedException();
        }

        public void Disconnect()
        {
            throw new NotImplementedException();
        }

        public void Execute(object cmdParams)
        {
            throw new NotImplementedException();
        }
    }

}
