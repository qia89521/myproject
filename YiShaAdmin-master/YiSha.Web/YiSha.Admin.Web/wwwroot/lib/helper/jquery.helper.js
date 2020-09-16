
/*自动补全字符，不足前面用0代替*/
function CompletieStr(num, len) {
    if (num.length >= len) {
        return num;
    }
    else {
        var str = "";
        for (var i = num.length; i < len; i++) {
            str += "0";
        }
    }
    return str + num;
}

/*检测是否为数字
@num：输入字符
*/
function CheckIsNumber(num) {
    var re = /^[0-9]+.?[0-9]*$/; //判断字符串是否为数字 //判断正整数 /^[1-9]+[0-9]*]*$/ 
    if (!re.test(num)) {
        return false;
    }
    else {
        return true;
    }
}

/*
两数字相除，保留多位小数
@num1：除数
@num2：被除数
@len：小数点数量
*/
function ToDecimal2(num1, num2, len) {
    if (num2 == 0) {
        return 0;
    }
    else {
        return (num1 / num2).toFixed(len);
    }
}

/*清理非数字字符
obj:文本框控件 this
flag:true:表示整数，false:数字整数或者小数
*/
function ClearNoNum(obj, flag) {
    if (!flag) {
        obj.value = obj.value.replace(/[^\d.]/g, "");  //清除“数字”和“.”以外的字符  

        obj.value = obj.value.replace(/^\./g, "");  //验证第一个字符是数字而不是. 

        obj.value = obj.value.replace(/\.{2,}/g, "."); //只保留第一个. 清除多余的.   

        obj.value = obj.value.replace(".", "$#$").replace(/\./g, "").replace("$#$", ".");
    }
    else {
        obj.value = obj.value.replace(/\D/g, '');
    }
}

/**
对象数组移除
@key:数字key
@valu:值
*/
function ArrayRemoveObject(old_arry, key, value) {
    var array = [];
    for (var i = 0; i < old_arry.length; i++) {
        if (old_arry[i][key] != value) {
            array.push(old_arry[i]);
        }
    }
    return array;
}


/*筛选对象数组 如:[{file:1},{file:2}]
根据值从数组进行筛选
@obj_array:对象数组
@filed:根据那个字段啥U型
@value：字段值
*/
function FilterObjArray(obj_array, filed, value) {
    var array = [];
    for (var i = 0; i < obj_array.length; i++) {
        if (obj_array[i][filed] == value) {
            array.push(obj_array[i]);
        }
    }
    return array;
}


/**
 * 检测字符串是否为空
 * @param {any} str
 */
function IsNullEmpty(str) {
    if (str != "" && str != undefined && str != null) {
        return false;
    }
    return true;
}

/*筛选对象数组 如:[{file:1},{file:2}]
根据值从数组进行筛选
@obj_array:对象数组
@filed:根据那个字段啥U型
@value：字段值
*/
function FilterObj(obj_array, filed, value) {
    var obj = null;
    for (var i = 0; i < obj_array.length; i++) {
        if (obj_array[i][filed] == value) {
            obj = obj_array[i];
            break;
        }
    }
    return obj;
}


/*将对象数组的字段值，单独转成数组
@obj_array:对象数组
@filed:对象属性
*/
function GetArrayFromObjFiled(obj_array, filed) {
    var array = [];
    for (var i = 0; i < obj_array.length; i++) {
        array.push(obj_array[i][filed]);
    }
    return array;
}


/**
数组移除值
@key:数字key
@valu:值
*/
function ArrayRemoveValue(old_arry, value) {
    var array = [];
    for (var i = 0; i < old_arry.length; i++) {
        if (old_arry[i] != value) {
            array.push(old_arry[i]);
        }
    }
    return array;
}


/**
数字检测该值是否存在
@key:数字key
@valu:值
*/
function ArrayIsContainValue(array, value) {
    var isContain = false;
    for (var i = 0; i < array.length; i++) {
        if (array[i] == value) {
            isContain = true;
            break;
        }
    }
    return isContain;
}


/**
数组检测对象是否存在
@key:数字key
@valu:值
*/
function ArrayIsContainObject(old_arry, key, value) {
    var isContain = false;
    for (var i = 0; i < old_arry.length; i++) {
        if (old_arry[i][key] == value) {
            isContain = true;
        }
    }
    return isContain;
}


/**
从数组对象筛选第一个满足条件的对象
@key:数字key
@valu:值
*/
function ArrayGetObject(old_arry, key, value) {
    var obj = null;
    for (var i = 0; i < old_arry.length; i++) {
        if (old_arry[i][key] == value) {
            obj = old_arry[i];
            break;
        }
    }
    return obj;
}


/**
获取url参数
name:url参数名称
**/
function QuerryString(name) {
    var reg = new RegExp("(^|&)" + name + "=([^&]*)(&|$)");
    var r = window.location.search.substr(1).match(reg);
    if (r != null) return unescape(r[2]); return null;
}


/**
从url获取参数
url链接url
name:参数名称
**/
function QuerryFromUrl(url, name) {
    var reg = new RegExp("(^|&)" + name + "=([^&]*)(&|$)");
    var r = url.substr(1).match(reg);
    if (r != null) return unescape(r[2]); return null;
}

/*获取表单数据，返回json对象*/
function GetFormData(formElementId) {
    var fields = $("#" + formElementId).serializeArray(); //返回的并不是json格式数据
    var paramObj = {};
    //序列化查询条件参数对象
    $.each(fields, function (i, field) {
        var p = {};
        p[field.name] = field.value; //转为json对象格式数据

        if (CheckAttrIsContians(field.name, "_data_type")) {
            var data_type = $("#" + field.name).attr("_data_type");
            if (data_type == "int") {
                p[field.name] = parseInt(field.value);
            }
            else if (data_type == "float") {
                p[field.name] = parseFloat(field.value);
            }
        }
        $.extend(paramObj, p);
    });

    return paramObj;
}

/*
检测属性是否存在
@ID;元素id
@atrt:属性值
*/
function CheckAttrIsContians(id, ar) {
    if ($("#" + id).attr(ar) != null &&
        $("#" + id).attr(ar) != undefined) {
        return true;
    }
    else {
        return false;
    }
}
/**
获得当前时间
**/
function GetCurentTime() {
    var now = new Date();

    var year = now.getFullYear();       //年
    var month = now.getMonth() + 1;     //月
    var day = now.getDate();            //日

    var hh = now.getHours();            //时
    var mm = now.getMinutes();          //分
    var ss = now.getDay();              //秒

    var clock = year + "-";

    if (month < 10)
        clock += "0";

    clock += month + "-";

    if (day < 10)
        clock += "0";

    clock += day + " ";

    if (hh < 10)
        clock += "0";

    clock += hh + ":";
    if (mm < 10) clock += '0';
    clock += mm + ":";
    if (ss < 10) clock += '0';
    clock += ss;
    return (clock);
}


/*验证只能输入数字
       @len: 保留位数
       */
function CheckIsFormatNumber(str, len) {
    str = str.replace(/[^0-9.]/g, '');
    var newStr = str.split('');
    var newArray = [];
    var newLen = 0;
    var isFind = false;
    for (var y = 0; y < newStr.length; y++) {
        if (newStr[y] == ".") {
            isFind = true;
        }
        newArray.push(newStr[y])
        if (isFind) {
            if (newLen < len) {
                newLen++;
            }
            else {
                break;
            }
        }
    }
    if (str.indexOf(".") == str.length - 1) {
        newArray.push("0");
        newArray.push("0");
    }
    return newArray.join("");
}

//时间格式
Date.prototype.format = function (format) {
    /* 
     * eg:format="yyyy-MM-dd hh:mm:ss"; 
     */
    var o = {
        "M+": this.getMonth() + 1, // month  
        "d+": this.getDate(), // day  
        "h+": this.getHours(), // hour  
        "m+": this.getMinutes(), // minute  
        "s+": this.getSeconds(), // second  
        "q+": Math.floor((this.getMonth() + 3) / 3), // quarter  
        "S": this.getMilliseconds()
        // millisecond  
    }

    if (/(y+)/.test(format)) {
        format = format.replace(RegExp.$1, (this.getFullYear() + "").substr(4
            - RegExp.$1.length));
    }

    for (var k in o) {
        if (new RegExp("(" + k + ")").test(format)) {
            format = format.replace(RegExp.$1, RegExp.$1.length == 1
                ? o[k]
                : ("00" + o[k]).substr(("" + o[k]).length));
        }
    }
    return format;
}



/*
获取当前日期的前几天日期 返回 yyyy-mm-dd
curDay:当前时间
addDay：往前推时间 正式
*/
function GetAddDay(curDay, addDay) {
    var dd = curDay;
    dd.setDate(dd.getDate() + addDay);//获取AddDayCount天后的日期 
    var y = dd.getFullYear();
    var m = dd.getMonth() + 1;//获取当前月份的日期 
    if (m < 10) {
        m = "0" + m;
    }

    var d = dd.getDate();
    if (d < 10) {
        d = "0" + d;
    }
    return y + "-" + m + "-" + d;
}

/*
比较日期时间差
@sDate1：时间减数 格式yyyy-MM-dd
@sDate2：时间被减数 格式yyyy-MM-dd
@flag: d:返回天数差，h:小时差，m:分钟差，s:秒数差，ms:毫秒差
*/
function DateDiff(sDate1, sDate2, flag) {    //sDate1和sDate2是2006-12-18格式    
    var d1 = new Date(sDate1);
    var d2 = new Date(sDate2);
    var iDays = 0;
    if (flag == "d") {
        iDays = parseInt(d2 - d1) / 1000 / 60 / 60 / 24;   //把相差的毫秒数转换为天数   
        iDays = iDays + 1;
    }
    else if (flag == "h") {
        iDays = parseInt(d2 - d1) / 1000 / 60 / 60;    //把相差的毫秒数小时
    }
    else if (flag == "m") {
        iDays = parseInt(d2 - d1) / 1000 / 60;   //把相差的毫秒数转换分钟   
    }
    else if (flag == "s") {
        iDays = parseInt(d2 - d1) / 1000;    //把相差的毫秒数转换为秒   
    }
    else {
        iDays = parseInt(d2 - d1);
    }
    return iDays;
}

/*json数据美化
@json：json格式数据
*/
function JsonToBeautify(json) {
    if (typeof json != 'string') {
        json = JSON.stringify(json, undefined, 2);
    }
    json = json.replace(/&/g, '&amp;').replace(/</g, '&lt;').replace(/>/g, '&gt;');
    return json.replace(/("(\\u[a-zA-Z0-9]{4}|\\[^u]|[^\\"])*"(\s*:)?|\b(true|false|null)\b|-?\d+(?:\.\d*)?(?:[eE][+\-]?\d+)?)/g, function (match) {
        var cls = 'number';
        if (/^"/.test(match)) {
            if (/:$/.test(match)) {
                cls = 'key';
            } else {
                cls = 'string';
            }
        } else if (/true|false/.test(match)) {
            cls = 'boolean';
        } else if (/null/.test(match)) {
            cls = 'null';
        }
        return '<span class="' + cls + '">' + $.trim(match) + '</span>';
    });
}


/*生成指定位数的随机数*/
function GetRandom(len) {
    var jschars = ['0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'];
    var res = "";
    for (var i = 0; i < len; i++) {
        var id = Math.ceil(Math.random() * 35);
        res += jschars[id];
    }
    return res;

}


/**
 * 设置元素是否启用还是禁用
 * @param  roleCode 角色代码 
 *  @param  isAdd 是否新增
 *   @param  isOpearte 是否是操作人
 * @param isEnable 启用还是禁用
 */
function SetElmentIsEnable(roleCode, isAdd, isOpearte, isEnable) {
    if (isEnable) {
        $(".roleCode_" + roleCode + " select").removeAttr("disabled");
        $(".roleCode_" + roleCode + " input").removeAttr("disabled");
        $(".roleCode_" + roleCode + " textarea").removeAttr("disabled");
        $(".roleCode_" + roleCode + " button").removeAttr("disabled");
    }
    else {
        if (!isAdd) {
            $(".roleCode_" + roleCode + " select").attr("disabled", "disabled");
        } 
        if (!isOpearte) {
            $(".roleCode_" + roleCode + " input").attr("disabled", "disabled");
            $(".roleCode_" + roleCode + " textarea").attr("disabled", "disabled");
            $(".roleCode_" + roleCode + " button").attr("disabled", "disabled");
        }
    }
}

/**
 * 设置操作面板权限
 * @loginId
 * @loginRoleCode
 * @operatId
 * */
function SetOperatePower(loginId, loginRoleCode, operatId) {
    var isAdd = false;
    var isOpearte = false;
    if (IsNullEmpty(operatId)) {
        isAdd = true;
    }
    if (loginId == operatId) {
        isOpearte = true;
    }
    SetElmentIsEnable(loginRoleCode, isAdd, isOpearte, false);
}


/**
 *设置创建人数据不能更改
 * @param {any} login_id 登录用户id
 * @param {any} create_id 创建数据人id
 * @param {any} create_id 创建数据人id
 */
function SetOpElmentIsEnable(login_id, create_id, shenheStatus) {
    if (login_id != create_id || parseInt(shenheStatus) > 0) {
        
        $(".roleCode_op button").attr("disabled", "disabled");
        $(".roleCode_op select").attr("disabled", "disabled");
        $(".roleCode_op input").attr("disabled", "disabled");
        $(".roleCode_op textarea").attr("disabled", "disabled");
    }
}

/**
* 设置权限模板
* param roleCode：权限代码
* param operatId  选择的用户id
*/
function SetOperatePannel(roleCodes, roleCode, operatId) {
    //设置审核面板
    var loginRoleCode_2 = "";
    if (!IsContainsRoleCode(roleCodes, roleCode)) {
        loginRoleCode_2 = roleCode;
    }
    //SetOperatePower(loginId, loginRoleCode, operatId) {
    SetOperatePower(loginId, loginRoleCode_2, operatId);
}

/**
 * 是否包含改角色
 * @param {any} codes 角色串
 * @param {any} code 指定角色
 */
function IsContainsRoleCode(codes, code) {
    if (codes.indexOf(code) > -1) {
        return true;
    }
    return false;
}



/////////////////////////////////////////////////////
//--------------js map对象---------------------//
///////////////////////////////////////////////////

function Map() {
    var struct = function (key, value) {
        this.key = key;
        this.value = value;
    }

    var put = function (key, value) {
        for (var i = 0; i < this.arr.length; i++) {
            if (this.arr[i].key === key) {
                this.arr[i].value = value;
                return;
            }
        }
        this.arr[this.arr.length] = new struct(key, value);
    }


    var get = function (key) {
        for (var i = 0; i < this.arr.length; i++) {
            if (this.arr[i].key === key) {
                return this.arr[i].value;
            }
        }
        return null;
    }

    var remove = function (key) {
        var v;
        for (var i = 0; i < this.arr.length; i++) {
            v = this.arr.pop();
            if (v.key === key) {
                continue;
            }
            this.arr.unshift(v);
        }
    }

    var toClean = function () {
        this.arr = [];
    }

    var containsKey = function (key) {
        for (var i = 0; i < this.arr.length; i++) {
            if (this.arr[i].key === key) {
                return true;
            }
        }
        return false;
    }

    var size = function () {
        return this.arr.length;
    }

    var isEmpty = function () {
        return this.arr.length <= 0;
    }

    var toArrays = function () {
        return this.arr;
    }

    var toKeyArray = function () {
        var arryes = [];
        for (var i = 0; i < this.arr.length; i++) {
            arryes.push(this.arr[i].key);
        }
        return arryes;
    }

    var toValueArray = function () {
        var arryes = [];
        for (var i = 0; i < this.arr.length; i++) {
            arryes.push(this.arr[i].value);
        }
        return arryes;
    }

    this.arr = new Array();
    this.get = get;
    this.put = put;
    this.remove = remove;
    this.size = size;
    this.containsKey = containsKey;
    this.isEmpty = isEmpty;
    this.toArrays = toArrays;
    this.toClean = toClean;
    this.toKeyArray = toKeyArray;
    this.toValueArray = toValueArray;
}
