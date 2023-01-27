world-geo-json-zh
===============
简体中文 Geo JSON 世界地图（zh-Hans, 1:110m）

Install
--------
```
npm i @surbowl/world-geo-json-zh
```

The data
--------
JSON 结构
```javascript
{
   "type": "FeatureCollection",
   "features": [
      {
         "type": "Feature",
         "properties": {
            "name": "中国",
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

本项目基于 [Natural Earth](https://www.naturalearthdata.com/) 的 [1:110m 地图](https://www.naturalearthdata.com/downloads/110m-cultural-vectors/)（1:110m Cultural Vectors, Admin 0 – Countries 5.0.0-pre3, version 4.1.0），并对下列国家或地区做出调整：

|name|iso_a2|iso_a3|iso_n3|调整|备注|
|------|------|------|----|----|----|
|巴林|BH|BHR|048|增加|由于面积较小，在原版 Natural Earth 1:110m 地图中被省略|
|新加坡|SG|SGP|702|增加|由于面积较小，在原版 Natural Earth 1:110m 地图中被省略|
|台湾|TW|TWN|158|不单独列出|合并到中国（iso_a3：CHN）|

下列国家或地区暂无 ISO 3166 代码，用 -99 代替：

|name|iso_a2|iso_a3|iso_n3|
|------|------|------|----|
|北赛普勒斯土耳其共和国|-99|-99|-99|
|索马里兰|-99|-99|-99|
|科索沃|XK|-99|-99|

License
------------
[The Unlicense](https://github.com/Surbowl/world-geo-json-zh/blob/main/LICENSE)

Contributing
------------
欢迎大家在 Issues 中提交意见建议
