namespace GloryChanger_Commands.Commands
{
    /// <summary>ログリード</summary>
    public class Cmd3D : Command
    {
        protected override byte DH1 { get; } = 0x3D;

        public enum Cmd3DConfig
        {
            /// <summary>本体部保守ログ</summary>
            Config1 = 1,
            /// <summary>本体部点検ログ</summary>
            Config2 = 2,
            /// <summary>本体部データログ</summary>
            Config3 = 3,
            /// <summary>エラー時系列ログ</summary>
            Config4 = 4,
            /// <summary>処理再現ログ</summary>
            Config5 = 10,
            /// <summary>日別計数ログ</summary>
            Config6 = 11,
            /// <summary>硬貨部保守ログ</summary>
            Config7 = 41,
            /// <summary>硬貨部点検ログ</summary>
            Config8 = 42,
            /// <summary>硬貨部エラー時系列ログ</summary>
            Config9 = 44,
            /// <summary>紙幣部保守ログ</summary>
            Config10 = 81,
            /// <summary>紙幣部点検ログ</summary>
            Config11 = 82,
            /// <summary>紙幣部エラー時系列ログ</summary>
            Config12 = 84
        }

        public void SetData(Cmd3DConfig config, string index)
        {
            var idx = index.PadLeft(4, '0');
            var temp = new System.Collections.Generic.List<byte>();
            temp.Add(((int)config).GetByteAtDigit(2));
            temp.Add(((int)config).GetByteAtDigit(1));
            temp.Add((byte)(System.Convert.ToByte(idx.Substring(0, 1), 16) + 48));
            temp.Add((byte)(System.Convert.ToByte(idx.Substring(1, 1), 16) + 48));
            temp.Add((byte)(System.Convert.ToByte(idx.Substring(2, 1), 16) + 48));
            temp.Add((byte)(System.Convert.ToByte(idx.Substring(3, 1), 16) + 48));
            Data = temp.ToArray();
        }
    }
}
