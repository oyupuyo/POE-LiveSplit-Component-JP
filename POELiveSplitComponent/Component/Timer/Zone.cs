using System.Collections.Generic;

namespace POELiveSplitComponent.Component.Timer
{
    public class Zone : IZone
    {
        public enum IconType { Wp, NoWp, Town }

        public static readonly List<Zone> ZONES;

        private static readonly Dictionary<Zone, Zone> REQUIRED;

        public static readonly Dictionary<IZone, IconType> ICONTYPES;

        static Zone()
        {
            ZONES = new List<Zone>();
            REQUIRED = new Dictionary<Zone, Zone>();
            ICONTYPES = new Dictionary<IZone, IconType>();

            Zone kitavaPart1Kill = new Zone("大聖堂の屋上", 1);
            Zone act6Home = new Zone("ライオンアイの見張り場", 2);
            Zone act7Home = new Zone("橋の野営地", 2);
            Zone sarnRamparts = new Zone("サーンの城壁", 2);
            Zone act8Home = new Zone("サーンの野営地", 2);
            Zone bloodAqueduct = new Zone("血の水道橋", 2);
            Zone act9Home = new Zone("ハイゲート", 2);
            Zone act10Home = new Zone("オリアスの船着場", 2);

            add(new Zone("ライオンアイの見張り場", 1), IconType.Town);
            add(new Zone("海岸", 1), IconType.Wp);
            add(new Zone("ぬかるみの干潟", 1), IconType.NoWp);
            add(new Zone("陸続きの島", 1), IconType.NoWp);
            add(new Zone("海底通路", 1), IconType.Wp);
            add(new Zone("岩棚", 1), IconType.Wp);
            add(new Zone("険しい山道", 1), IconType.Wp);
            add(new Zone("牢獄 -下層-", 1), IconType.Wp);
            add(new Zone("牢獄 -上層-", 1), IconType.NoWp);
            add(new Zone("囚人の門", 1), IconType.Wp);
            add(new Zone("船の墓場", 1), IconType.Wp);
            add(new Zone("憤怒の洞窟", 1), IconType.Wp);
            add(new Zone("怒りの洞窟", 1), IconType.NoWp);
            add(new Zone("南の森", 1), IconType.Wp);
            add(new Zone("森の野営地", 1), IconType.Town);
            add(new Zone("荒廃農地", 1), IconType.NoWp);
            add(new Zone("十字路", 1), IconType.Wp);
            add(new Zone("罪の間 -第一層-", 1), IconType.Wp);
            add(new Zone("罪の間 -第二層-", 1), IconType.NoWp);
            add(new Zone("壊れた橋", 1), IconType.Wp);
            add(new Zone("川沿いの道", 1), IconType.Wp);
            add(new Zone("西の森", 1), IconType.Wp);
            add(new Zone("編む者の巣穴", 1), IconType.NoWp);
            add(new Zone("湿地", 1), IconType.Wp);
            add(new Zone("ヴァールの遺跡", 1), IconType.NoWp);
            add(new Zone("北の森", 1), IconType.Wp);
            add(new Zone("大洞窟", 1), IconType.Wp);
            add(new Zone("古代のピラミッド", 1), IconType.NoWp);
            add(new Zone("サーン市街", 1), IconType.Wp);
            add(new Zone("サーンの野営地", 1), IconType.Town);
            add(new Zone("スラム", 1), IconType.NoWp);
            add(new Zone("火葬場", 1), IconType.Wp);
            add(new Zone("下水道", 1), IconType.Wp);
            add(new Zone("市場", 1), IconType.Wp);
            add(new Zone("戦場", 1), IconType.Wp);
            add(new Zone("船着場", 1), IconType.Wp);
            add(new Zone("ソラリス寺院 -第一層-", 1), IconType.Wp);
            add(new Zone("ソラリス寺院 -第二層-", 1), IconType.Wp);
            add(new Zone("黒檀の兵舎", 1), IconType.Wp);
            add(new Zone("ルナリス寺院 -第一層-", 1), IconType.Wp);
            add(new Zone("ルナリス寺院 -第二層-", 1), IconType.NoWp);
            add(new Zone("帝国の庭園", 1), IconType.Wp);
            add(new Zone("図書館", 1), IconType.Wp);
            add(new Zone("神の杖", 1), IconType.Wp);
            add(new Zone("神の杖 -上層-", 1), IconType.NoWp);
            add(new Zone("水道橋", 1), IconType.Wp);
            add(new Zone("ハイゲート", 1), IconType.Town);
            add(new Zone("干上がった湖", 1), IconType.NoWp);
            add(new Zone("鉱山 -第一層-", 1), IconType.NoWp);
            add(new Zone("鉱山 -第二層-", 1), IconType.NoWp);
            add(new Zone("水晶鉱脈", 1), IconType.Wp);
            add(new Zone("ダレッソの夢", 1), IconType.NoWp);
            add(new Zone("カオムの夢", 1), IconType.NoWp);
            add(new Zone("カオムの要塞", 1), IconType.Wp);
            add(new Zone("大闘技場", 1), IconType.Wp);
            add(new Zone("魔獣の内部 -第一層-", 1), IconType.NoWp);
            add(new Zone("魔獣の内部 -第二層-", 1), IconType.NoWp);
            add(new Zone("摘出", 1), IconType.Wp);
            add(new Zone("頂への道", 1), IconType.NoWp);
            add(new Zone("奴隷収容所", 1), IconType.Wp);
            add(new Zone("監督官の塔", 1), IconType.Town);
            add(new Zone("奴隷管理区画", 1), IconType.NoWp);
            add(new Zone("オリアス広場", 1), IconType.Wp);
            add(new Zone("テンプラーの裁判所", 1), IconType.Wp);
            add(new Zone("イノセンスの間", 1), IconType.Wp);
            add(new Zone("焼けた裁判所", 1), IconType.NoWp);
            add(new Zone("破壊された広場", 1), IconType.Wp);
            add(new Zone("納骨堂", 1), IconType.NoWp);
            add(new Zone("聖廟", 1), IconType.Wp);
            add(kitavaPart1Kill, IconType.Wp);
            add(act6Home, IconType.Town, kitavaPart1Kill);
            add(new Zone("海岸", 2), IconType.Wp, act6Home);
            add(new Zone("ぬかるみの干潟", 2), IconType.NoWp, act6Home);
            add(new Zone("カルイの要塞", 2), IconType.NoWp, act6Home);
            add(new Zone("尾根", 2), IconType.Wp, act6Home);
            add(new Zone("牢獄 -下層-", 2), IconType.Wp, act6Home);
            add(new Zone("シャヴロンの塔", 2), IconType.NoWp, act6Home);
            add(new Zone("囚人の門", 2), IconType.Wp, act6Home);
            add(new Zone("西の森", 2), IconType.Wp, act6Home);
            add(new Zone("川沿いの道", 2), IconType.Wp, act6Home);
            add(new Zone("南の森", 2), IconType.Wp, act6Home);
            add(new Zone("怒りの洞窟", 2), IconType.NoWp, act6Home);
            add(new Zone("ビーコン", 2), IconType.Wp, act6Home);
            add(new Zone("海水の王の岩礁", 2), IconType.Wp, act6Home);
            add(act7Home, IconType.Town);
            add(new Zone("壊れた橋", 2), IconType.NoWp, act7Home);
            add(new Zone("十字路", 2), IconType.Wp, act7Home);
            add(new Zone("フェルシュラインの遺跡", 2), IconType.NoWp, act7Home);
            add(new Zone("地下聖堂", 2), IconType.Wp, act7Home);
            add(new Zone("罪の間 -第一層-", 2), IconType.Wp, act7Home);
            add(new Zone("マリガロの聖域", 2), IconType.NoWp, act7Home);
            add(new Zone("罪の間 -第二層-", 2), IconType.NoWp, act7Home);
            add(new Zone("獣の巣", 2), IconType.Wp, act7Home);
            add(new Zone("焼け野原", 2), IconType.Wp, act7Home);
            add(new Zone("北の森", 2), IconType.Wp, act7Home);
            add(new Zone("土手道", 2), IconType.Wp, act7Home);
            add(new Zone("ヴァールの街", 2), IconType.Wp, act7Home);
            add(new Zone("堕落の寺院 -第一層-", 2), IconType.NoWp, act7Home);
            add(new Zone("堕落の寺院 -第二層-", 2), IconType.NoWp, act7Home);
            add(sarnRamparts, IconType.Wp);
            add(act8Home, IconType.Town, sarnRamparts);
            add(new Zone("有毒な排水路", 2), IconType.NoWp, act8Home);
            add(new Zone("ドードゥリの汚水槽", 2), IconType.Wp, act8Home);
            add(new Zone("波止場", 2), IconType.NoWp, act8Home);
            add(new Zone("穀物倉庫", 2), IconType.Wp, act8Home);
            add(new Zone("帝国の穀倉地帯", 2), IconType.Wp, act8Home);
            add(new Zone("ソラリス寺院 -第一層-", 2), IconType.Wp, act8Home);
            add(new Zone("ソラリス寺院 -第二層-", 2), IconType.NoWp, act8Home);
            add(new Zone("ソラリスの中央広場", 2), IconType.Wp, act8Home);
            add(new Zone("港の橋", 2), IconType.NoWp, act8Home);
            add(new Zone("ルナリスの中央広場", 2), IconType.Wp, act8Home);
            add(new Zone("ルナリス寺院 -第一層-", 2), IconType.Wp, act8Home);
            add(new Zone("ルナリス寺院 -第二層-", 2), IconType.NoWp, act8Home);
            add(new Zone("浴場", 2), IconType.Wp, act8Home);
            add(bloodAqueduct, IconType.Wp);
            add(act9Home, IconType.Town, bloodAqueduct);
            add(new Zone("谷底への道", 2), IconType.NoWp, act9Home);
            add(new Zone("ヴァスティリ砂漠", 2), IconType.Wp, act9Home);
            add(new Zone("山麓", 2), IconType.Wp, act9Home);
            add(new Zone("坑道", 2), IconType.Wp, act9Home);
            add(new Zone("沸き立つ湖", 2), IconType.NoWp, act9Home);
            add(new Zone("採石場", 2), IconType.Wp, act9Home);
            add(new Zone("精錬所", 2), IconType.NoWp, act9Home);
            add(new Zone("魔獣の内部", 2), IconType.NoWp, act9Home);
            add(new Zone("腐った核", 2), IconType.NoWp, act9Home);
            add(act10Home, IconType.Town);
            add(new Zone("大聖堂の屋上", 2), IconType.NoWp, act10Home);
            add(new Zone("荒廃した広場", 2), IconType.Wp, act10Home);
            add(new Zone("焼けた裁判所", 2), IconType.NoWp, act10Home);
            add(new Zone("冒涜された広間", 2), IconType.Wp, act10Home);
            add(new Zone("聖廟", 2), IconType.Wp, act10Home);
            add(new Zone("運河", 2), IconType.NoWp, act10Home);
            add(new Zone("餌場", 2), IconType.NoWp, act10Home);
            add(new Zone("カルイの海岸", 2), IconType.Town, act10Home);
        }

        private static void add(Zone zone, IconType icon, Zone requirement = null)
        {
            ZONES.Add(zone);
            ICONTYPES[zone] = icon;
            REQUIRED[zone] = requirement;
        }

        // Creates a zone representation using the zone name.
        // Tries to guess the part using information about the encountered zones so far.
        public static IZone Parse(string zoneName, HashSet<IZone> encounteredZones)
        {
            return new Zone(zoneName, guessPart(zoneName, encounteredZones));
        }

        // Returns part 1 if the requirements for part 2 are not met. 2 otherwise.
        // Assuming the run started in act 1, if the previous zone requirements are not met for the part 2 equivalent, then we are certain that this is a part 1 zone.
        // Assuming runners don't go back to part 1 zones once in part 2, we are quite certain that this is a part 2 zone.
        // They may return to part 1 towns but returning part 2 instead would not cause more or fewer splits to occur.
        private static int guessPart(string zoneName, HashSet<IZone> encounteredZones)
        {
            Zone zone = new Zone(zoneName, 2);
            // Check to make sure that a part 2 version exists for this zone.
            if (REQUIRED.ContainsKey(zone))
            {
                Zone required = REQUIRED[zone];
                if (required == null || encounteredZones.Contains(required))
                {
                    return 2;
                }
            }
            return 1;
        }

        private string name;
        private int part;

        private Zone(string name, int part)
        {
            this.name = name;
            this.part = part;
        }

        public string Serialize()
        {
            return ToString();
        }

        public string SplitName()
        {
            if (part == 1)
            {
                return name;
            }
            return ToString();
        }

        public override string ToString()
        {
            return name + " (Part " + part + ")";
        }

        public override bool Equals(object obj)
        {
            Zone zone = obj as Zone;
            if (zone == null)
            {
                return false;
            }
            return name.Equals(zone.name) && part == zone.part;
        }

        public override int GetHashCode()
        {
            return name.GetHashCode() * 23 + part;
        }
    }
}
