[![GitHub license](https://img.shields.io/github/license/geann/palettes-in-sitecore.svg)](https://github.com/geann/palettes-in-sitecore/blob/master/LICENSE)
![GitHub language count](https://img.shields.io/github/languages/count/geann/palettes-in-sitecore.svg?style=flat)
![GitHub top language](https://img.shields.io/github/languages/top/geann/palettes-in-sitecore.svg?style=flat)
![GitHub repo size](https://img.shields.io/github/repo-size/geann/palettes-in-sitecore.svg?style=flat)
![GitHub contributors](https://img.shields.io/github/contributors/geann/palettes-in-sitecore)
![GitHub commit activity](https://img.shields.io/github/commit-activity/y/geann/palettes-in-sitecore)

# Palettes in Sitecore
Palettes in Sitecore module implements a Colour Palette Management in Sitecore and allows to select a different colour theme for individual pages with a possibility to override it at a component level when required. So, that content editors can easily apply the desired look & feel in a simple and intuitive way without a need for code changes by developers.

# Sitecore Packages
Sitecore packages contain:
1. **Data Templates**
   - Palette - the main definition of a _Palette Item_ with style and coloyur tokens;
     ![Palette Data Template](/assets/palette%20data%20template.png) 
   - Palette Theme - an optional classification of palette styles;
     ![Palette Theme Data Template](/assets/palette%20theme%20data%20template.png) 
   - Theme Content Page - an extension to the standard _Content Page_ template to choose the required Palette at a page level;
     ![Theme Content Page Data Template](/assets/theme%20content%20page%20data%20template.png)      
   - Theme Component - a base template for compoment data sources to choose the required Palette at a component level;
     ![Theme Component Data Template](/assets/theme%20component%20data%20template.png) 
1. **Renderings**
   - Palette Styles - an aggregated CSS output for **all** pre-defined palette styles;
   - ThemeComponent - a sample component to illustrate how to use and benefit from the flexible style settings in the front-end;  
1. **Palette Themes** - some pre-defined colour schemes.

# How to Install
1. Include the _PalettesInSitecore_ project to your Visual Studio solution;
1. Install Sitecore packages;   

# License
The Palettes in Sitecore module is released under the MIT license that means that you can modify and use it how you want even for commercial use. Please give it a star if you like it and your experience was positive.
