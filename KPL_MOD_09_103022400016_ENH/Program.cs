using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace KPL_MOD_09_103022400016_ENH
{
    public class Program
    {
        private static void main(String[] args)
        {
            BankTransferConfig config = new BankTransferConfig();
            if (config.config.lang == "en")
            {
                Console.WriteLine("Please insert the amount of money to transfer:");
            }
            else
            {
                Console.WriteLine("Masukkan jumlah uang yang akan di transfer:");
            }

            double uang_tf = Convert.ToInt32(Console.ReadLine());
            double biaya_tf = 0;

            if (uang_tf <= config.config.transfer.threshold) {
                biaya_tf += config.config.transfer.low_fee;
            }else
            {
                biaya_tf += config.config.transfer.high_fee;
            }

            if(config.config.lang == "en")
            {
                Console.WriteLine("Transfer Fee = "+ uang_tf);
                Console.WriteLine("Amount ="+ (biaya_tf + uang_tf));
                Console.WriteLine("Select transfer method:" );
            }else
            {
                Console.WriteLine("Biaya Transfer = " + uang_tf);
                Console.WriteLine("Total Biaya =" + (biaya_tf + uang_tf));
                Console.WriteLine("Pilih metode transfer:");
            }

            Console.WriteLine("1." + config.config.methods[0]);
            Console.WriteLine("2." + config.config.methods[1]);
            Console.WriteLine("3." + config.config.methods[2]);
            Console.WriteLine("4." + config.config.methods[3]);
            int pilihan_method = Convert.ToInt32(Console.ReadLine());

            if (config.config.lang == "en")
            {
                Console.WriteLine(" Please type " + config.config.confirm.en + "to confirm the transaction:");
            }
            else
            {
                Console.WriteLine(" Ketik " + config.config.confirm.id + "untuk mengkonfirmasi transaksi:");
            }

            string jawaban = Console.ReadLine();
            if (jawaban == config.config.confirm.en)
            {
                Console.WriteLine("The transfer is completed using" + config.config.methods[pilihan_method - 1]);
            }
            else if (jawaban == config.config.confirm.id) {
                Console.WriteLine("Proses transfer berhasil menggunakan " + config.config.methods[pilihan_method - 1]);
            }
            else { 
                
                if(config.config.lang == "en")
                {
                    Console.WriteLine("Transfer is cancelled");
                }else
                {

                    Console.WriteLine("Transfer dibatalkan");
                }
             }
        }
        public Program() { }

    }
}