using System.Text;

namespace edcs_edlen_death_counter_service
{
    /// <summary>
    /// Binary evaluator
    /// </summary>

    public static class BinaryReaderHelper
    {
        /// <summary>
        /// Range validation
        /// </summary>
        /// <param name="data"></param>
        /// <param name="offset"></param>
        /// <param name="length"></param>
        /// <returns></returns>

        public static bool IsRangeValid(
            byte[] data,
            int offset,
            int length)
        {
            if (data == null)
            {
                return false;
            }

            if (offset < 0)
            {
                return false;
            }

            if (length < 0)
            {
                return false;
            }

            if (offset > data.Length)
            {
                return false;
            }

            if (length > data.Length - offset)
            {
                return false;
            }

            return true;
        }


        /// <summary>
        /// Le utf 16
        /// </summary>
        /// <param name="data"></param>
        /// <param name="offset"></param>
        /// <param name="byteCount"></param>
        /// <returns></returns>

        public static string ReadUtf16LeString(
            byte[] data,
            int offset,
            int byteCount)
        {
            if (!IsRangeValid(
                    data,
                    offset,
                    byteCount))
            {
                return string.Empty;
            }

            string value =
                Encoding.Unicode.GetString(
                    data,
                    offset,
                    byteCount);

            int nullIndex =
                value.IndexOf('\0');

            if (nullIndex >= 0)
            {
                value =
                    value.Substring(
                        0,
                        nullIndex);
            }

            return value.Trim();
        }


        /// <summary>
        /// Le uint 166
        /// </summary>
        /// <param name="data"></param>
        /// <param name="offset"></param>
        /// <returns></returns>

        public static int ReadUInt16LE(
            byte[] data,
            int offset)
        {
            if (!IsRangeValid(
                    data,
                    offset,
                    2))
            {
                return 0;
            }

            return
                (data[offset] & 0xFF) |
                ((data[offset + 1] & 0xFF) << 8);
        }


        /// <summary>
        /// Le int 32
        /// </summary>
        /// <param name="data"></param>
        /// <param name="offset"></param>
        /// <returns></returns>

        public static int ReadInt32LE(
            byte[] data,
            int offset)
        {
            if (!IsRangeValid(
                    data,
                    offset,
                    4))
            {
                return 0;
            }

            return
                (data[offset] & 0xFF) |
                ((data[offset + 1] & 0xFF) << 8) |
                ((data[offset + 2] & 0xFF) << 16) |
                ((data[offset + 3] & 0xFF) << 24);
        }


        /// <summary>
        /// Le uint 32
        /// </summary>
        /// <param name="data"></param>
        /// <param name="offset"></param>
        /// <returns></returns>

        public static long ReadUInt32LE(
            byte[] data,
            int offset)
        {
            return
                (uint)ReadInt32LE(
                    data,
                    offset);
        }
    }
}
