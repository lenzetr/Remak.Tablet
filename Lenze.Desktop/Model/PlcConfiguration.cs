using System;

namespace Lenze.Desktop.Model
{
    public class PlcConfiguration
    {
        public string IpAddress
        {
            get
            {
                var result = string.Empty;
                try
                {
                    var databaseValue = Global.Database.GetSettingsValue("IpAddress");

                    result = databaseValue;
                }
                catch (Exception)
                {
                    //
                }

                return result;
            }

            set => Global.Database.InsertSetting("IpAddress", value.ToString());
        }

        public string Port
        {
            get
            {
                var result = string.Empty;
                try
                {
                    var databaseValue = Global.Database.GetSettingsValue("Port");

                    result = databaseValue;
                }
                catch (Exception)
                {
                    //
                }

                return result;
            }

            set => Global.Database.InsertSetting("Port", value.ToString());
        }
    }

}
