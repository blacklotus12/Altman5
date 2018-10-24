# Need to do
## UI控件方面
* datagridview实现排序功能      ✔
* 标签栏实现关闭按钮以及右键菜单    (第三方tabcontrol解决，但无法固定)
* 右键菜单不同位置选项不同      ✔
* 树状分组功能，已经支持隐藏侧边
* 设置菜单tab标签化
* 最小化到任务栏功能            ✔
* 带历史记录的combobox,有+-符号     (历史记录已实现，未实现+-)
* 带hint的textbox           ✔

## BUG更新方面
* shellcmder没有设置cmd路径的功能   ✔   （setp命令）
* win和linux的路径符问题            ✔
* 数据库树状点击过快更新数据会出现bug
* cmder在shell不成功状态下会卡住

## 功能实现方面
* evalCode功能
* socks代理功能
* shell分类管理
* shell查找功能
* 插件功能
* 显示原始错误信息 (考虑新页面实现显示返回原始内容)
* 标签获取信息出错直接关闭
* 手动刷新CustomType    ✔


## 代码和重构方面
* filemanage中status的简化      ✔
* shell_extra_setting的结构重新设计。
* 异步使用await和async化
* 多语言的简化和及时更新
* CustomType的简化
* wpf实现