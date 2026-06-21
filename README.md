#圖書管理系統（Library Management System）

##專案簡介
本專案使用 C# Windows Forms 開發，製作一個圖書管理系統。  
使用者可以透過系統管理書籍資料、查詢書本資訊、記錄借閱狀況、管理會員借閱紀錄，並在會員歸還書籍後產生還書單。  
本系統整合 ListView、ListBox、ComboBox、TextBox、Button、ImageList 等 Windows Forms 控制項，提供書籍管理、會員借閱、歸還、逾期判斷、逾期天數計算、逾期罰金與停止借閱天數計算等功能。

##功能說明
###查詢系統
左側查詢系統提供書籍資料輸入與查詢輔助功能，使用者可以透過欄位查看或編輯目前選取的書籍資料。
查詢系統包含以下欄位：

書名  
作者  
類別  
存放位置  
備註  
借閱狀況  

當使用者在中央書籍清單中選取一本書時，系統會自動將該書的詳細資料帶入左側查詢系統欄位中，方便使用者確認書籍資訊。  
使用者也可以直接在書名欄位輸入書名，搭配借閱或歸還功能進行操作。  
借閱狀況欄位會顯示目前書籍狀態，例如「可借閱」或「已借出」。

###按鈕區
左側下方按鈕區提供圖書管理與借閱操作功能，讓使用者可以直接對目前選取或輸入的書籍進行管理。

按鈕區包含以下功能：

新增書籍  
修改選取書籍  
刪除選取書籍  
借閱  
歸還  

新增書籍：將查詢系統欄位中輸入的書名、作者、類別、存放位置、備註與借閱狀況新增到書籍清單中。  
修改選取書籍：修改目前在書籍清單中選取的書籍資料。  
刪除選取書籍：刪除目前選取的書籍資料，刪除前會跳出確認訊息。  
借閱：將目前選取或輸入的書籍借給目前選擇的會員，並新增會員借閱紀錄。  
歸還：將目前選取或輸入的書籍設定為已歸還，並更新會員借閱紀錄與會員還書單。

###書籍清單顯示
主畫面使用 `ListView` 顯示所有書籍資料，並支援多種檢視方式：
大圖示  
詳細資料  
小圖示  
清單  
大圖示加詳細資料  

使用者可透過右側的檢視方式選單切換顯示模式。

###書籍圖片顯示
系統使用 `ImageList` 搭配 `ListView`，讓每一本書可以顯示對應的封面圖片，使書籍瀏覽更直覺。

###書籍查詢與選取
使用者可以選取書籍清單中的項目，系統會自動將該書資料帶入左側欄位，方便查看與修改。

###會員系統
系統提供會員選擇功能，使用者可以切換不同會員，例如：
王小明  
李小華  
陳美玲  
林志強  

切換會員後，系統會自動更新該會員的借書清單、借閱紀錄與還書單。

###借閱功能
使用者選擇會員與書籍後，點擊「借閱」按鈕即可借出書籍。  
借閱成功後，系統會自動：

將書籍狀態改為「已借出」  
新增會員借閱紀錄  
計算應還日期  
更新會員目前借書清單  
更新會員借閱紀錄  

###歸還功能
使用者選擇會員與已借出的書籍後，點擊「歸還」按鈕即可完成還書。  
歸還成功後，系統會自動：

將書籍狀態改為「可借閱」  
記錄還書日期  
判斷是否逾期  
計算逾期天數  
計算逾期罰金  
計算停止借閱天數  
更新會員還書單  

###會員借書清單
右側借書清單會顯示目前會員尚未歸還的書籍。  
切換會員時，系統會自動清空上一位會員的清單，並只顯示目前會員的借閱中書籍，避免資料混亂。

###會員借閱紀錄
系統會顯示目前會員所有借閱紀錄，包含：
會員  
書名  
借閱日期  
應還日期  
歸還日期  
狀態  
逾期天數  
罰金  

若書籍逾期未還或逾期歸還，紀錄會以紅色標示。

###會員還書單
會員還書單專門顯示已歸還的書籍紀錄，包含：
會員  
書名  
借出日期  
到期日  
還書日期  
是否逾期  
逾期天數  
逾期罰金  
停借天數  

此功能可協助管理者清楚查看會員的還書狀況與逾期處理結果。

###逾期判斷功能
系統設定固定可借天數：
可借天數：7 天  
若目前日期或還書日期超過應還日期，系統會自動判斷為逾期。

###逾期罰金計算
系統設定固定逾期罰金：
每日罰金：5 元  
計算公式：
逾期罰金 = 逾期天數 × 每日罰金

###逾期停止借閱天數
系統設定固定停借規則：
逾期 1 天，停止借閱 2 天  
計算公式：
停借天數 = 逾期天數 × 2


##執行說明
###開發環境
Visual Studio  
C#  
.NET Framework  
Windows Forms  

###執行步驟
開啟專案檔案。  
確認表單控制項名稱與程式碼中的名稱一致。  
確認 `ImageList` 已加入書籍封面圖片。  
點擊「開始（Start）」執行程式。  
選擇會員。  
選擇書籍。  
點擊「借閱」或「歸還」進行圖書管理操作。  
查看右側會員借書清單、借閱紀錄與還書單。


##執行畫面
###主畫面
<img width="996" height="648" alt="image" src="https://github.com/user-attachments/assets/fa0c971a-4463-40f6-b714-31f02fc9cefa" />
<img width="1272" height="844" alt="image" src="https://github.com/user-attachments/assets/62a39752-4de3-4963-9885-137f56e2ff11" />

###書籍詳細資料顯示
<img width="1276" height="838" alt="image" src="https://github.com/user-attachments/assets/9496639d-f4a2-4a61-936e-960c55589cd3" />

###會員借閱功能
輸入會員姓名
<img width="1274" height="844" alt="image" src="https://github.com/user-attachments/assets/3bf9878c-d573-42f9-80f2-899c3d87213d" />

###會員借閱書籍紀錄
<img width="1248" height="842" alt="image" src="https://github.com/user-attachments/assets/907f7355-c175-4779-96ee-9de657f8a7d2" />
<img width="338" height="542" alt="image" src="https://github.com/user-attachments/assets/38bf5ab6-7f4b-45a6-b08e-d714cc76c678" />
<img width="330" height="556" alt="image" src="https://github.com/user-attachments/assets/48e90d34-f45a-4a15-9c43-ef3434ec1abb" />

###會員還書單
<img width="1274" height="838" alt="image" src="https://github.com/user-attachments/assets/2e670db8-c2bd-475c-8b1f-1dd6bb5dded7" />
<img width="322" height="194" alt="image" src="https://github.com/user-attachments/assets/a8b89af2-c317-4a8f-8061-157a5801ed67" />
<img width="320" height="200" alt="image" src="https://github.com/user-attachments/assets/c23ee8e1-f762-4254-aede-ca3107a33028" />
<img width="348" height="206" alt="image" src="https://github.com/user-attachments/assets/00891b5a-a053-46dd-8cb8-a02a152bb327" />


##使用技術
C# Windows Forms 介面開發  
ListView 書籍資料與紀錄顯示  
ListBox 會員借書清單顯示  
ComboBox 檢視方式、借閱狀態與會員選擇  
TextBox 書籍資料輸入  
Button 新增、修改、刪除、借閱、歸還與查詢功能  
ImageList 書籍封面圖片管理  
Dock 排版控制左側輸入區、中央書籍清單與右側工具區  
LINQ 查詢會員借閱紀錄  
DateTime 日期計算  
List<T> 儲存書籍資料與借閱紀錄  
MessageBox 操作提示與防呆訊息  

##專案架構
圖書管理系統/  
├── frmBooks.cs  
│   └── 主程式邏輯、書籍管理、借閱、歸還、逾期計算  
├── frmBooks.Designer.cs  
│   └── Windows Forms 介面配置  
├── Program.cs  
│   └── 程式進入點  
└── Resources/  
    └── 書籍封面圖片資源  

##主要資料結構
###Book 書籍資料
```csharp
class Book
{
    public string Name { get; set; }
    public string Author { get; set; }
    public string Kind { get; set; }
    public string Status { get; set; }
    public string Location { get; set; }
    public string Note { get; set; }
}
