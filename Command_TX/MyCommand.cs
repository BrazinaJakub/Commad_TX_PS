using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tecnomatix.Engineering;
using System.IO;


namespace EngineeringCommands
{
    public class MyCommand : TxButtonCommand
    {
        public MyCommand()
        {
        }
        public override void Execute(System.Object cmdParams)
        {
            var path = @"C:\PS_SDK\data.txt";
            TxObjectList selectedObject = TxApplication.ActiveSelection.GetItems();
            if (selectedObject != null)
            {
                TxRobot robot = selectedObject[0] as TxRobot;                
                if (robot != null)
                {
                    List<TxJoint> joints = robot.Joints.ToList();
                    File.WriteAllText(path, robot.Name + "\n");
                    foreach (var joint in joints)
                    {
                        if (!joint.IsDependent)
                        {
                            File.AppendAllText(path, (joint.CurrentValue * 180 / Math.PI) + "\n");
                        }
                    }
                    for (int i = 0; i < 6; i++)
                    {
                        joints[i].CurrentValue = 40 * Math.PI / 180;
                        File.AppendAllText(path, "Osa " + (i + 1) + " byla zapsaná\n");
                    }
                }
                else File.WriteAllText(path, "Select robot!");
            }
            else File.WriteAllText(path, "Select robot!");
            
            // The command logic
            // Prepare the cylinder creation data
            //TxCylinderCreationData cd = new TxCylinderCreationData();
            //cd.Name = "myCylinder";
            //cd.Base = new TxVector(0, 0, 0);
            //cd.Top = new TxVector(0, 0, 300);
            //cd.Radius = 100;
            //// Get the first item from the selection
            //TxObjectList selectedItems = TxApplication.ActiveSelection.GetItems();
            //ITxGeometryCreation geoParent = selectedItems[0] as ITxGeometryCreation;

            //// If the selected item is of a type under which a geometry can be created
            //// (that is, if it implements ITxGeometryCreation), create the cylinder
            //// under it.
            //if (geoParent != null)
            //    geoParent.CreateSolidCylinder(cd);





            //string text = Environment.NewLine + "Here is more text for the file";

            //System.IO.File.AppendAllText(path, text);
        }

        public override string Name
        {
            get
            {
                //ResourceManager resourceMgr = new ResourceManager("EngineeringCommands.StringTable", this.GetType().Assembly);
                return "Robot info";
            }
        }

        public override string Category
        {
            get
            {
                //ResourceManager resourceMgr = new ResourceManager("EngineeringCommands.StringTable", this.GetType().Assembly);
                return "CMD_CATEGORY";
            }
        }

        //public override string Bitmap { get; } = "C:/";

        //public class CommandResource : ITxButtonCommandResources, ITxCommand
        //{
        //    string ITxButtonCommandResources.Name { get; } = "TX_Command_1"; //throw new NotImplementedException();

        //    string ITxButtonCommandResources.Tooltip => throw new NotImplementedException();

        //    string ITxButtonCommandResources.Description => throw new NotImplementedException();

        //    string ITxButtonCommandResources.Category => throw new NotImplementedException();

        //    string ITxButtonCommandResources.Bitmap => throw new NotImplementedException();

        //    ITxCommandEnabler ITxCommand.CommandEnabler => throw new NotImplementedException();

        //    bool ITxCommand.Connect()
        //    {
        //        throw new NotImplementedException();
        //    }

        //    void ITxCommand.Disconnect()
        //    {
        //        throw new NotImplementedException();
        //    }

        //    void ITxCommand.Execute(object cmdParams)
        //    {
        //        throw new NotImplementedException();
        //    }

        //}
    }
}
