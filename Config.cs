namespace NetProto
{
    public class Config
    {
        public const int CONNECTION_TIMEOUT = 3000;
        // Size of receive buffer.
        public const int BUFFER_SIZE = 1024;
        public const int HEADER_SIZE = 4;
        public const string SALT = "DH";
        public const int DH1BASE = 3;
        public const int DH1PRIME = 0x7FFFFFC3;
    }
}
