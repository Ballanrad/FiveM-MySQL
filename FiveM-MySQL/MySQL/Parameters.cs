﻿using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace GHMatti.MySQL
{
    public static class Parameters
    {
        public static void AddParameters(this MySqlCommand cmd, IDictionary<string, dynamic> parameters)
        {
            if (parameters != null)
                foreach(KeyValuePair<string, dynamic> kvp in parameters)
                    cmd.Parameters.AddWithValue(kvp.Key, kvp.Value);
        }

        public static IDictionary<string, dynamic> TryParseParameters(dynamic parameters)
        {
            IDictionary<string, dynamic> parsedParameters = null;
            try
            {
                parsedParameters = parameters;
            }
            catch
            {
                CitizenFX.Core.Debug.WriteLine("[GHMattiMySQL Warning] Parameters are not in Dictionary-shape");
                parsedParameters = null;
            }
                
            return parsedParameters;
        }
    }
}
