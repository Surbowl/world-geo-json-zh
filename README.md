world-geo-json-zh
===============
简体中文 Geo JSON 世界地图（zh-Hans, 1:110m），带有国家地区的 ISO 3166 代码、中文简称与全称。

Install
--------
```
npm i @surbowl/world-geo-json-zh
```

The data
--------
**JSON 结构**

```javascript
{
   "type": "FeatureCollection",
   "features": [
      {
         "type": "Feature",
         "properties": {
            "name": "中国",
            "full_name": "中华人民共和国",
            "iso_a2": "CN",   // ISO 3166 Alpha-2 code
            "iso_a3": "CHN",  // ISO 3166 Alpha-3 code
            "iso_n3": "156"   // ISO 3166 Numeric code
         },
         "geometry": {
            "type": "MultiPolygon",
            "coordinates": [ ...... ]
         }
      },
      {
         "type": "Feature",
         "properties": {
            "name": "意大利",
            "full_name": "意大利共和国",
            "iso_a2": "IT",
            "iso_a3": "ITA",
            "iso_n3": "380"
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

**注意事项**

国际标准化组织尚未制定下列国家地区的 ISO 3166 代码，如果您使用 ISO 3166 作为 id，可能会遇到键值冲突。您可以根据业务需要将 -99 替换为自定义值。

|name|iso_a2|iso_a3|iso_n3|
|------|------|------|----|
|北赛普勒斯土耳其共和国|-99|-99|-99|
|索马里兰|-99|-99|-99|
|科索沃|XK|-99|-99|

**参考文献**

- [1] [Natural Earth](https://www.naturalearthdata.com/). [1:110m Cultural Vectors 地图](https://www.naturalearthdata.com/downloads/110m-cultural-vectors/). （1:110m Cultural Vectors, Admin 0 – Countries 5.0.0-pre3, version 4.1.0）.
- [2] [中华人民共和国外交部](https://www.mfa.gov.cn/). [国家（地区）列表](https://www.mfa.gov.cn/web/gjhdq_676201/gj_676203/yz_676205/).
- [3] [联合国](https://www.un.org/). [会员国名单](https://www.un.org/zh/about-us/member-states).
- [4] [国际标准化组织](https://www.iso.org/). [ISO 3166 Country Codes](https://www.iso.org/iso-3166-country-codes.html).

License
------------
[The Unlicense](https://github.com/Surbowl/world-geo-json-zh/blob/main/LICENSE)

Contributing
------------
欢迎大家在 Issues 中提交意见建议