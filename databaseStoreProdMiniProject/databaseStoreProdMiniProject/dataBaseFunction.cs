using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace databaseStoreProdMiniProject
{
    public class dataBaseFunction
    {
       
        public SqlConnection CreateConnection()
        {
            SqlConnection myCon = null;
           
            myCon = new SqlConnection(@"Data Source=ANDY_LEONG-PC\sqlexpress; Database=projectA; User ID=projectA; Password=P@ssw0rd;");
            myCon.Open();
                
           
            return myCon;

        }

        public void insertData(PersonObject personObject)
        {
                SqlConnection con = CreateConnection();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "Execute InsertPerson @name,@nric,@address,@email,@dOB,@phoneNo";
                cmd.Parameters.Add("@name", SqlDbType.VarChar, 50).Value = personObject.Name;
                cmd.Parameters.Add("@nric", SqlDbType.NChar, 10).Value = personObject.Nric;
                cmd.Parameters.Add("@address", SqlDbType.VarChar, 50).Value = personObject.Address;
                cmd.Parameters.Add("@email", SqlDbType.VarChar, 50).Value = personObject.Email;
                cmd.Parameters.Add("@dOB", SqlDbType.Date).Value = personObject.DOB;
                cmd.Parameters.Add("@phoneNo", SqlDbType.Int).Value = personObject.PhoneNo;
                cmd.ExecuteNonQuery();
                con.Close();

            
            
        }

        public List<PersonObject> getAllData()
        {
            List<PersonObject> listPObject = new List<PersonObject>();
            SqlConnection con = CreateConnection();
            SqlDataReader rd;

            using (con) {
                SqlCommand cmd = new SqlCommand("GetPersonData",con);
                cmd.CommandType = CommandType.StoredProcedure;
   
                rd = cmd.ExecuteReader();
                while (rd.Read()) {
                    
                    PersonObject pObject = new PersonObject();
                    pObject.Name = rd["name"].ToString();
                    pObject.Nric = rd["nric"].ToString();
                    pObject.DOB = Convert.ToDateTime(rd["dob"]);
                    pObject.PhoneNo = Convert.ToInt32(rd["phoneNo"]);
                    pObject.Address = rd["address"].ToString();
                    pObject.Email = rd["email"].ToString();

                    listPObject.Add(pObject);
                    
                    
                }
                

                rd.Close();
            }
            
            con.Close();

            return listPObject;


        }
    }

    
}
