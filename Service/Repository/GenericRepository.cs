using Core.Base;
using System.Collections.Generic;
using Dapper;
using System.Data.SqlClient;
using System.Linq;
using System.Data;

namespace Service.Repository
{

    //INTERFACE DEN ÇAGRILIR BU KISIMDAN İS E ÜZERİNDE İŞLME YAPILIR
    //PROTOTİPLER KULLANILIR
    public class GenericRepository<T> where T:BaseEntity
    {
        private readonly IDbConnection dbConnection;
        //ilk çagrılmada tüm bilgiler yüklenir 1 defa
        public GenericRepository()
        {
            dbConnection = new SqlConnection("Data Source=DESKTOP-DU9JPA1;Initial Catalog=dbYakitTakip;Integrated Security=True");
        }

        string EntityName = typeof(T).Name;

        //tablonun kolon isimlerini dizi halinegetiriyor
        string[] EntityNameColumns()
        {
            return dbConnection.Query<string>("SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = N'"+EntityName+"'").ToArray();
        }
        //bu fonksiyon ile dizi şeklinde alınan kolon isimleri arasına , konulması işlemi yapılmakta
        //1 den başlıyor çnki ilk colon id 
        //string beforeColumnNames=""  adlı dgişken bizin values degerlerimizi
        //başına @ koymamızı saglıyor 
        //@ koyulmazsa column tanımlanış olmuyor
        string CreateEntityNames(string beforeColumnNames="",bool isUpdate = false,int start=1)
        {
            var columns = EntityNameColumns();
            string createEntityNames = "";
            for (int i = start; i < columns.Length; i++)
            {
                var element = columns[i];
                //sona virgül atma
                createEntityNames += (isUpdate?element:"")+beforeColumnNames + element + (i!=columns.Length-1? ",":"");
            }

            return createEntityNames;
        }

      
        public List<T> GetAll()
        {
            string sql = "select " + CreateEntityNames(start: 0) + " from " + EntityName;
            return dbConnection.Query<T>(sql).ToList();
        }

        public  T Get(int id)
        {
            return dbConnection.QueryFirst<T>("select " + CreateEntityNames() + " from " + EntityName + " where id=" + id); ;
        }

        

       public void Insert(T item)
        {
            dbConnection.Execute("Insert into " + EntityName + " values(" + CreateEntityNames("@") + ")",item);
        }

        public void Update(T item)
        {
            var sql = "Update " + EntityName + " set " + CreateEntityNames("=@", true) + " where Id = @Id";
            dbConnection.Execute(sql,item);
        }
        public void Delete(T item)
        {
            dbConnection.Execute("Delete from " + EntityName + "where Id= " + item.Id);
        }

        /// <summary>
        /// yukarıdaki 5 işlem dışında herhang bir sorgu gerektiren işlemde aşagıdaki dynamic metodlar kullanılır.
        /// //örnegin groupby 
        /// //count 
        /// //order by 
        /// //select count(*) from tablename
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        /// 
        //IEnumerable liste şeklinde tip
        public IEnumerable<dynamic> Query(string sql)
        {
            return dbConnection.Query(sql);
        }
        public IEnumerable<dynamic> Query(string sql,object item)
        {
            return dbConnection.Query(sql,item);
        }
        //dinamik sadece bir obje zaten o yüzden queryfirst kullanılıyor
        public dynamic QueryFirst(string sql)
        {
            return dbConnection.QueryFirst(sql);
        }
        public dynamic QueryFirst(string sql, object item)
        {
            return dbConnection.Query(sql, item);
        }
        //bunlar execute fonksiyonları 
        //direk çalıştırmak için
        //liste veya obje dönmeyen metodları çaıştırak için 
        //insert,update,commit,transaction
        public void Execute(string sql)
        {
            dbConnection.Execute(sql);
        }
        public void Execute(string sql,object item)
        {
            dbConnection.Execute(sql,item);
        }
   
    }
}
