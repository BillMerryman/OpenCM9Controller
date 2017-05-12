
namespace CM9DesktopController
{
    public partial class frmCM9DesktopController
    {
        public const byte RS485_PACKET_FLAG_WIDTH = 2;
        public const byte RS485_ID_WIDTH = 1;
        public const byte RS485_ID_POSITION = 2;
        public const byte RS485_PARAMETER_LENGTH_WIDTH = 1;
        public const byte RS485_PARAMETER_LENGTH_POSITION = 3;
        public const byte RS485_INSTRUCTION_WIDTH = 1;
        public const byte RS485_INSTRUCTION_POSITION = 4;
        public const byte RS485_ERROR_WIDTH = 1;
        public const byte RS485_ERROR_POSITION = 4;
        public const byte RS485_PARAMETER_START_POSITION = 5;
        public const byte RS485_CHECKSUM_WIDTH = 1;
        public const byte RS485_TX_HEADER_WIDTH = RS485_PACKET_FLAG_WIDTH + RS485_ID_WIDTH + RS485_PARAMETER_LENGTH_WIDTH + RS485_INSTRUCTION_WIDTH;
        public const byte RS485_RX_HEADER_WIDTH = RS485_PACKET_FLAG_WIDTH + RS485_ID_WIDTH + RS485_PARAMETER_LENGTH_WIDTH + RS485_ERROR_WIDTH;
        public const byte RS485_TX_NON_PARAMETER_WIDTH = RS485_TX_HEADER_WIDTH + RS485_CHECKSUM_WIDTH;
        public const byte RS485_RX_NON_PARAMETER_WIDTH = RS485_RX_HEADER_WIDTH + RS485_CHECKSUM_WIDTH;
        public const byte RS485_TX_PARAMETERS_READ_START_POSITION = 0;
        public const byte RS485_TX_PARAMETERS_READ_START_WIDTH = 1;
        public const byte RS485_TX_PARAMETERS_READ_LENGTH_POSITION = 1;
        public const byte RS485_TX_PARAMETERS_READ_LENGTH_WIDTH = 1;
        public const byte RS485_RX_INPUT_VOLTAGE_ERROR = (1 << 0);
        public const byte RS485_RX_ANGLE_LIMIT_ERROR = (1 << 1);
        public const byte RS485_RX_OVERHEATING_ERROR = (1 << 2);
        public const byte RS485_RX_RANGE_ERROR = (1 << 3);
        public const byte RS485_RX_CHECKSUM_ERROR = (1 << 4);
        public const byte RS485_RX_OVERLOAD_ERROR = (1 << 5);
        public const byte RS485_RX_INSTRUCTION_ERROR = (1 << 6);
        public const byte RS485_RX_GENERAL_ERROR = (1 << 7);
        public const int BUFFER_SIZE = 256;
    }
}
