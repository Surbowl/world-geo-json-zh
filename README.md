# world-geo-json-zh
简体中文 Geo JSON 世界地图（zh-Hans, 1:110m）

GIS 数据来自 [Natural Earth](https://www.naturalearthdata.com/)（1:110m Cultural Vectors, Admin 0 – Countries, version 4.1.0）

### JSON
```javascript
{
   "type":"FeatureCollection",
   "features":[
      {
         "type":"Feature",
         "properties":{
            "name":"斐濟",
            "iso_a2":"FJ",      // ISO alpha-2
            "iso_a3":"FJI",     // ISO alpha-3
            "iso_n3":"242"      // UN M49 Numerical Code
         },
         "geometry":{
            "type":"MultiPolygon",
            "coordinates":[ ...... ]
         }
      },
      {
         "type":"Feature",
         "properties":{
            "name":"坦桑尼亚",
            "iso_a2":"TZ",
            "iso_a3":"TZA",
            "iso_n3":"834"
         },
         "geometry":{
            "type":"Polygon",
            "coordinates":[ ...... ]
         }
      }, 
      ......
   ]
}
```

### 贡献
欢迎大家在 Issues 中提交意见建议；GIS 数据来自 [Natural Earth](https://www.naturalearthdata.com/)，因此本仓库不接受修改 coordinates 的 PR。