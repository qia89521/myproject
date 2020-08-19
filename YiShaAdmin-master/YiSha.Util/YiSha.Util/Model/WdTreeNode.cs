using System;
using System.Collections.Generic;
using System.Text;

namespace YiSha.Util.Model
{
    /// <summary>
    /// 属性菜单节点类
    /// </summary>
    [Serializable]
    public class WdTreeNode
    {
        //[{"id":"6023","text":"佛山分公司","value":"6023","showcheck":true,"isexpand":true,"complete":true,"hasChildren":true,"ChildNodes":[]}]
        public string id { get; set; }

        public string text { get; set; }

        public string value { get; set; }

        public bool showcheck { get; set; }

        public bool isexpand { get; set; }

        public bool complete { get; set; }

        public bool hasChildren { get; set; }

        public int checkstate { get; set; }

        //新增属性start
        public string isPublished { get; set; }

        public string createDate { get; set; }

        public string updateDate { get; set; }
        //end
        public List<object> ChildNodes { get; set; }

        public WdTreeNode() { }

        public WdTreeNode(string id, string txt, string value, bool showCheck, bool isExpand, bool isComplete, int checkstate)
        {
            this.id = id;
            this.text = txt;
            this.value = value;
            this.showcheck = showCheck;
            this.isexpand = isExpand;
            this.complete = isComplete;
            this.checkstate = checkstate;
        }


        public WdTreeNode(string id, string txt, string value, bool showCheck,
            bool isExpand, bool isComplete, int checkstate, string isPublished, string createDate, string updateDate)
        {
            this.id = id;
            this.text = txt;
            this.value = value;
            this.showcheck = showCheck;
            this.isexpand = isExpand;
            this.complete = isComplete;
            this.checkstate = checkstate;
            this.isPublished = isPublished == "1" ? "已发布" : "未发布";
            this.createDate = createDate;
            this.updateDate = updateDate;
        }

        public WdTreeNode(string id, string txt, string value, bool showCheck,
           bool isExpand, bool isComplete, int checkstate, string isPublished, string createDate)
        {
            this.id = id;
            this.text = txt;
            this.value = value;
            this.showcheck = showCheck;
            this.isexpand = isExpand;
            this.complete = isComplete;
            this.checkstate = checkstate;
            this.isPublished = isPublished == "1" ? "已发布" : "未发布";
            this.createDate = createDate;
        }
    }
}
