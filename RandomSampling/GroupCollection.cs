using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace RandomSampling
{
    class GroupCollection : IEnumerable<GroupItem>
    {
        public GroupCollection()
        {
            Items = new GroupItem[8];
            if (!File.Exists("data.json"))
            {
                var obj = new Group[8];
                for (int i = 0; i < 8; i++)
                {
                    obj[i] = new Group();
                }
                File.WriteAllText("data.json", JsonConvert.SerializeObject(obj));
            }
            var items2 = JsonConvert.DeserializeObject<List<Group>>(File.ReadAllText("data.json"));
            for (int i = 0; i < 8; i++)
            {
                if (items2.Count < i)
                {
                    break;
                }
                Items[i] = new GroupItem(items2[i]);
            }
        }

        private GroupItem[] Items { get; set; }

        public GroupItem this[string name] => Items.FirstOrDefault(x => x.GroupName == name);

        public GroupItem this[int index] => Items[index];

        public IEnumerator<GroupItem> GetEnumerator()
        {
            return Items.AsEnumerable().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return Items.GetEnumerator();
        }
    }
}
