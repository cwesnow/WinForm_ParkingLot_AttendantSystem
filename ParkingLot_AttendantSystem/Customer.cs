
using System;
namespace ITS3100_ParkingApp3
{
    public class Customer
    {
        // Properties
        private string name;
        private string plate;

        // Accessors
        public string Name
        {
            get { return name; }
            set { name = value.Trim(); }
        }

        public string Plate
        {
            get { return plate; }
            set { plate = value.Trim(); }
        }

        // Constructor
        public Customer(string N, string P)
        {
            if (N.Trim().Length < 3 || N.Trim().Length > 25) throw new System.ArgumentOutOfRangeException();
            else this.name = N.Trim();
            if (P.Trim().Length < 1 || P.Trim().Length > 8) throw new System.ArgumentOutOfRangeException();
            else this.plate = P.Trim();
        }

        // Tests
        #region Customer Tests

        public static string testCustomerNameNull()
        {
            string result = "";

            // Test - Fullname is null
            try
            {
                Customer testCustomerNameNull = new Customer(null, "NullValu");
            }
            catch (Exception ex)
            {
                result += string.Format(result + "\r\n Error: {0}", ex.Message);
            }
            return result;
        }

        public static string testCustomerNameShort()
        {
            string result = "";

            // Test - Fullname is too short
            try
            {
                Customer testCustomerNameShort = new Customer("", "Blank");
            }
            catch (Exception ex)
            {
                result += string.Format(result + "\r\n Error: {0}", ex.Message);
            }
            return result;
        }

        public static string testCustomerNameLong()
        {
            string result = "";

            // Test - Fullname is too long
            try
            {
                Customer testCustomerNameLong = new Customer("ABCDEFGHIJKLMNOPQRSTUVWXYZ", "2 LONG");
            }
            catch (Exception ex)
            {
                result += string.Format(result + "\r\n Error: {0}", ex.Message);
            }
            return result;
        }

        public static string testCustomerPlateNull()
        {
            string result = "";

            // Test - License Plate is Null
            try
            {
                Customer testCustomerPlateNull = new Customer("Null Plates", null);
            }
            catch (Exception ex)
            {
                result += string.Format(result + "\r\n Error: {0}", ex.Message);
            }
            return result;
        }

        public static string testCustomerPlateShort()
        {
            string result = "";

            // Test - License Plate is too short
            try
            {
                Customer testCustomerPlateShort = new Customer("Test Customer Plate", "");
            }
            catch (Exception ex)
            {
                result += string.Format(result + "\r\n Error: {0}", ex.Message);
            }
            return result;
        }

        public static string testCustomerPlateLong()
        {
            string result = "";

            // Test - License Plate is too long
            try
            {
                Customer testCustomerPlateLong = new Customer("Test Customer Plate", "123456789");
            }
            catch (Exception ex)
            {
                result += string.Format(result + "\r\n Error: {0}", ex.Message);
            }
            return result;
        }

        #endregion

    }
}