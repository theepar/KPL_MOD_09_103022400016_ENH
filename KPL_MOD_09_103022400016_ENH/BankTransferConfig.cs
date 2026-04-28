using System;
using System.Text.Json;
using System.IO;
using KPL_MOD_09_103022400016_ENH;

public class BankTransferConfig {
    public config config;
    private const string filepath = @"BankTransferConfig.json";
    public BankTransferConfig() {
        try {
            readConfig();
        }
        catch(Exception) {
            setDefault();
            writeConfig();
        }


    }
    public void readConfig()
    {
        string json = File.ReadAllText(filepath);
        config = JsonSerializer.Deserialize<config>(json);
    }

    public void writeConfig() {
        JsonSerializerOptions options = new JsonSerializerOptions()
        {
            WriteIndented = true,
        };
        string json = JsonSerializer.Serialize(config, options);
        File.WriteAllText(filepath, json);
    }

    public void setDefault()
    {
        config = new config();
        config.lang = "en";
        Transfer transfer = new Transfer(25000000, 6500, 15000);
        config.transfer = transfer;
        List<string> list = new List<string>();
        list.Add("RTO (real-time)");
        list.Add("SKN");
        list.Add("RTGS");
        list.Add("BI FAST");
        Confirmation confirmation = new Confirmation();
        confirmation.en = "yes";
        confirmation.id = "ya";
        config.confirm = confirmation;
    }
}
