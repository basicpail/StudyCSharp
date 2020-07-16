namespace BookRentalShopApp
{
    public enum BaseMode
    {
        NONE,   //기본상태
        INSERT, //입력상태
        UPDATE, //수정상태
        DELETE,
        SELECT
    }

    public class Commons
    {
        //공통 DB연결 문자열
        public static readonly string CONNSTR =
            "Data Source=localhost;Port=3306;Database=bookrentalshop;Uid=root;Password=mysql_p@ssw0rd";

        
    }
}
