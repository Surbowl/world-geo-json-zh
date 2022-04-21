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
geometry 数据来自 [Natural Earth](https://www.naturalearthdata.com/)（1:110m Cultural Vectors, Admin 0 – Countries 5.0.0-pre3, version 4.1.0）

**Json 结构：**
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

以下国家或地区的 ISO 3166 Country Code 未定义，用 -99 表示

|iso_a2|iso_a3|iso_n3|name|
|------|------|------|----|
|-99|-99|-99|北赛普勒斯土耳其共和国|
|-99|-99|-99|索马里兰|
|XK|-99|-99|科索沃|

License
------------
[The Unlicense](https://github.com/Surbowl/world-geo-json-zh/blob/main/LICENSE)

Contributing
------------
欢迎大家在 Issues 中提交意见建议；geometry 数据来自 Natural Earth，请勿提交修改 geometry 属性的 PR。
