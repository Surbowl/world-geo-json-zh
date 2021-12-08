world-geo-json-zh
===============
简体中文 Geo JSON 世界地图（zh-Hans, 1:110m）

the data
--------

geometry 数据来自 [Natural Earth](https://www.naturalearthdata.com/)（1:110m Cultural Vectors, Admin 0 – Countries, version 4.1.0）

**JSON 结构：**
```javascript
{
   "type": "FeatureCollection",
   "features": [
      {
         "type": "Feature",
         "properties": {
            "name": "中国",   // 国家或地区的惯用名
            "iso_a2": "CN",   // ISO 3166 Alpha-2 code
            "iso_a3": "CHN",  // ISO 3166 Alpha-3 code
            "iso_n3": "156"   // ISO 3166 Numeric code
         },
         "geometry": {
            "type": "MultiPolygon",
            "coordinates": [ ...... ]
         }
      },
      ......
   ]
}
```

**国家/地区列表：**

ISO Country Code 未定义时用 -99 替代

|iso_a2|iso_a3|iso_n3|name|
|------|------|------|----|
|FJ|FJI|242|斐济|
|TZ|TZA|834|坦桑尼亚|
|EH|ESH|732|西撒哈拉|
|CA|CAN|124|加拿大|
|US|USA|840|美国|
|KZ|KAZ|398|哈萨克斯坦|
|UZ|UZB|860|乌兹别克斯坦|
|PG|PNG|598|巴布亚新几内亚|
|ID|IDN|360|印度尼西亚|
|AR|ARG|032|阿根廷|
|CL|CHL|152|智利|
|CD|COD|180|刚果民主共和国|
|SO|SOM|706|索马里|
|KE|KEN|404|肯尼亚|
|SD|SDN|729|苏丹|
|TD|TCD|148|乍得|
|HT|HTI|332|海地|
|DO|DOM|214|多米尼加|
|RU|RUS|643|俄罗斯|
|BS|BHS|044|巴哈马|
|FK|FLK|238|马尔维纳斯群岛（福克兰）|
|NO|NOR|578|挪威|
|GL|GRL|304|格陵兰|
|TF|ATF|260|法属南部和南极领地|
|TL|TLS|626|东帝汶|
|ZA|ZAF|710|南非|
|LS|LSO|426|莱索托|
|MX|MEX|484|墨西哥|
|UY|URY|858|乌拉圭|
|BR|BRA|076|巴西|
|BO|BOL|068|玻利维亚|
|PE|PER|604|秘鲁|
|CO|COL|170|哥伦比亚|
|PA|PAN|591|巴拿马|
|CR|CRI|188|哥斯达黎加|
|NI|NIC|558|尼加拉瓜|
|HN|HND|340|洪都拉斯|
|SV|SLV|222|萨尔瓦多|
|GT|GTM|320|危地马拉|
|BZ|BLZ|084|伯利兹|
|VE|VEN|862|委内瑞拉|
|GY|GUY|328|圭亚那|
|SR|SUR|740|苏里南|
|FR|FRA|250|法国|
|EC|ECU|218|厄瓜多尔|
|PR|PRI|630|波多黎各|
|JM|JAM|388|牙买加|
|CU|CUB|192|古巴|
|ZW|ZWE|716|津巴布韦|
|BW|BWA|072|博茨瓦纳|
|NA|NAM|516|纳米比亚|
|SN|SEN|686|塞内加尔|
|ML|MLI|466|马里|
|MR|MRT|478|毛里塔尼亚|
|BJ|BEN|204|贝宁|
|NE|NER|562|尼日尔|
|NG|NGA|566|尼日利亚|
|CM|CMR|120|喀麦隆|
|TG|TGO|768|多哥|
|GH|GHA|288|加纳|
|CI|CIV|384|科特迪瓦|
|GN|GIN|324|几内亚|
|GW|GNB|624|几内亚比绍|
|LR|LBR|430|利比里亚|
|SL|SLE|694|塞拉利昂|
|BF|BFA|854|布基纳法索|
|CF|CAF|140|中非|
|CG|COG|178|刚果共和国|
|GA|GAB|266|加蓬|
|GQ|GNQ|226|赤道几内亚|
|ZM|ZMB|894|赞比亚|
|MW|MWI|454|马拉维|
|MZ|MOZ|508|莫桑比克|
|SZ|SWZ|748|斯威士兰|
|AO|AGO|024|安哥拉|
|BI|BDI|108|布隆迪|
|IL|ISR|376|以色列|
|LB|LBN|422|黎巴嫩|
|MG|MDG|450|马达加斯加|
|PS|PSE|275|巴勒斯坦|
|GM|GMB|270|冈比亚|
|TN|TUN|788|突尼斯|
|DZ|DZA|012|阿尔及利亚|
|JO|JOR|400|约旦|
|AE|ARE|784|阿联酋|
|QA|QAT|634|卡塔尔|
|KW|KWT|414|科威特|
|IQ|IRQ|368|伊拉克|
|OM|OMN|512|阿曼|
|VU|VUT|548|瓦努阿图|
|KH|KHM|116|柬埔寨|
|TH|THA|764|泰国|
|LA|LAO|418|老挝|
|MM|MMR|104|缅甸|
|VN|VNM|704|越南|
|KP|PRK|408|朝鲜|
|KR|KOR|410|韩国|
|MN|MNG|496|蒙古|
|IN|IND|356|印度|
|BD|BGD|050|孟加拉|
|BT|BTN|064|不丹|
|NP|NPL|524|尼泊尔|
|PK|PAK|586|巴基斯坦|
|AF|AFG|004|阿富汗|
|TJ|TJK|762|塔吉克斯坦|
|KG|KGZ|417|吉尔吉斯斯坦|
|TM|TKM|795|土库曼斯坦|
|IR|IRN|364|伊朗|
|SY|SYR|760|叙利亚|
|AM|ARM|051|亚美尼亚|
|SE|SWE|752|瑞典|
|BY|BLR|112|白俄罗斯|
|UA|UKR|804|乌克兰|
|PL|POL|616|波兰|
|AT|AUT|040|奥地利|
|HU|HUN|348|匈牙利|
|MD|MDA|498|摩尔多瓦|
|RO|ROU|642|罗马尼亚|
|LT|LTU|440|立陶宛|
|LV|LVA|428|拉脱维亚|
|EE|EST|233|爱沙尼亚|
|DE|DEU|276|德国|
|BG|BGR|100|保加利亚|
|GR|GRC|300|希腊|
|TR|TUR|792|土耳其|
|AL|ALB|008|阿尔巴尼亚|
|HR|HRV|191|克罗地亚|
|CH|CHE|756|瑞士|
|LU|LUX|442|卢森堡|
|BE|BEL|056|比利时|
|NL|NLD|528|荷兰|
|PT|PRT|620|葡萄牙|
|ES|ESP|724|西班牙|
|IE|IRL|372|爱尔兰|
|NC|NCL|540|新喀里多尼亚|
|SB|SLB|090|所罗门群岛|
|NZ|NZL|554|新西兰|
|AU|AUS|036|澳大利亚|
|LK|LKA|144|斯里兰卡|
|CN|CHN|156|中国|
|TW|TWN|158|台湾|
|IT|ITA|380|意大利|
|DK|DNK|208|丹麦|
|GB|GBR|826|英国|
|IS|ISL|352|冰岛|
|AZ|AZE|031|阿塞拜疆|
|GE|GEO|268|格鲁吉亚|
|PH|PHL|608|菲律宾|
|MY|MYS|458|马来西亚|
|BN|BRN|096|文莱|
|SI|SVN|705|斯洛文尼亚|
|FI|FIN|246|芬兰|
|SK|SVK|703|斯洛伐克|
|CZ|CZE|203|捷克|
|ER|ERI|232|厄立特里亚|
|JP|JPN|392|日本|
|PY|PRY|600|巴拉圭|
|YE|YEM|887|也门|
|SA|SAU|682|沙特阿拉伯|
|AQ|ATA|010|南极洲|
|-99|-99|-99|北赛普勒斯土耳其共和国|
|CY|CYP|196|塞浦路斯|
|MA|MAR|504|摩洛哥|
|EG|EGY|818|埃及|
|LY|LBY|434|利比亚|
|ET|ETH|231|埃塞俄比亚|
|DJ|DJI|262|吉布提|
|-99|-99|-99|索马里兰|
|UG|UGA|800|乌干达|
|RW|RWA|646|卢旺达|
|BA|BIH|070|波斯尼亚和黑塞哥维那|
|MK|MKD|807|北马其顿|
|RS|SRB|688|塞尔维亚|
|ME|MNE|499|黑山|
|XK|-99|-99|科索沃|
|TT|TTO|780|特立尼达和多巴哥|
|SS|SSD|728|南苏丹|

contributing
------------
欢迎大家在 Issues 中提交意见建议；geometry 数据来自 Natural Earth，请勿提交修改 geometry 属性的 PR。
