


using uint8_t = System.Byte;
using uint16_t = System.UInt16;
using uint32_t = System.UInt32;
using uint64_t = System.UInt64;

using int8_t = System.SByte;
using int16_t = System.Int16;
using int32_t = System.Int32;
using int64_t = System.Int64;

using float32 = System.Single;

using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace DroneCAN
{

    public partial class DroneCAN {
        static void encode_uavcan_protocol_param_ExecuteOpcode_req(uavcan_protocol_param_ExecuteOpcode_req msg, dronecan_serializer_chunk_cb_ptr_t chunk_cb, object ctx) {
            uint8_t[] buffer = new uint8_t[8];
            _encode_uavcan_protocol_param_ExecuteOpcode_req(buffer, msg, chunk_cb, ctx, true);
        }

        static uint32_t decode_uavcan_protocol_param_ExecuteOpcode_req(CanardRxTransfer transfer, uavcan_protocol_param_ExecuteOpcode_req msg) {
            uint32_t bit_ofs = 0;
            _decode_uavcan_protocol_param_ExecuteOpcode_req(transfer, ref bit_ofs, msg, true);
            return (bit_ofs+7)/8;
        }

        static void _encode_uavcan_protocol_param_ExecuteOpcode_req(uint8_t[] buffer, uavcan_protocol_param_ExecuteOpcode_req msg, dronecan_serializer_chunk_cb_ptr_t chunk_cb, object ctx, bool tao) {






            memset(buffer,0,8);

            canardEncodeScalar(buffer, 0, 8, msg.opcode);

            chunk_cb(buffer, 8, ctx);





            memset(buffer,0,8);

            canardEncodeScalar(buffer, 0, 48, msg.argument);

            chunk_cb(buffer, 48, ctx);





        }

        static void _decode_uavcan_protocol_param_ExecuteOpcode_req(CanardRxTransfer transfer,ref uint32_t bit_ofs, uavcan_protocol_param_ExecuteOpcode_req msg, bool tao) {








            canardDecodeScalar(transfer, bit_ofs, 8, false, ref msg.opcode);


            bit_ofs += 8;








            canardDecodeScalar(transfer, bit_ofs, 48, true, ref msg.argument);


            bit_ofs += 48;






        }

    }

}
