# 概要
ITSS準拠の研修カリキュラム「プログラミングの基礎（B121）」のうち、「文法：式と演算子」の実習として、数値の四則演算プログラムを作る実習の完成品サンプルです。
各課題は別々のプログラム（別プロジェクト）として作成してください。また、作成するアプリケーションはWindows Formを想定しています。
ここで掲示しているプログラムは正解サンプルです。実際の課題実施に際しては、新人にはゼロからプログラムを作ってもらいます。

# 課題

## 事前準備
Visual StudioでC#のWindows Formプロジェクトを作成してください。


## 課題1: 四則演算（整数）

### 新人用説明文
下記の要件を満たすプログラムを作ってください。

- 3つのテキストボックスと、4つのボタン、「＋」「ｰ」「×」「÷」がフォームに配置されている。
- ボタンが押されると、テキストボックス2個に入力された数値を計算し、3つめのテキストボックスに表示する。計算内容は、押されたボタンの種類に応じて決定する。
- 入力される文字は整数の数字のみとします。小数や文字が入力された場合は、エラーが発生してプログラムが停止しても構いません。

できあがり品のイメージは下図のようになります（細かいところは各自で好きに作って構いません）。

![](images/ArithmeticCalc1.png)

#### 参考: テキストボックスの文字を数値に変換する
プログラミング言語「C#」は、見た目が「5」「8」といった数字であっても、それが「文字」なのか「数値」なのかを厳密に区別します。テキストボックスは文字を入力する部品なので、テキストボックスの「TextBox1.Text」などで得られる情報は「文字」です。計算に際しては、これを数値に変換してやる必要があります。
変換は、下記のように「int.Parse(変換したい文字)」という命令で実行可能です。

```cs
int value = int.Parse(valueString);
```

たとえば「int.Parse("5")」は、文字の「5」を数値の「5」に変換します。

### 講師用補足
この時点では、テキストボックスに入力される文字が「数値以外」である場合については考慮する必要ありません。エラーが出たらそのままにしてください。エラー対応については課題2で対応します。



## 課題2: 課題1: 四則演算（小数）

### 新人用説明文
課題1ではテキストボックスに整数だけが入る想定のプログラムになっていました。今後は、「1.34」などの小数も入力し、小数の演算を行えるように改造してみてください。
作業に際しては、課題1のプロジェクトフォルダーをコピーして名前を変え、ソリューションに追加して新しいプロジェクトを作ってください。

小数を入れるC#の変数は「int」ではなく「double」という型が使えます。また、文字からの変換で用いたParse命令も「double.Parse(変換したい文字)」で小数への変換ができますので、適宜変更して小数に対応した四則演算プログラムを作成してください。

#### 補足: double型と誤差
ここではとりあえず考慮しなくてもよいのですが、仕事で複雑な計算やお金の計算を行う場合、double型の変数を使うことで誤差が出てしまうことがあります。これは、コンピューターが数値を内部では二進数で表現していることに起因します。詳しい話は割愛しますが、小数を二進数で表現するとどうしても「表現しきれない部分」が発生してしまい、それが非常に小さな「差」として表面化するためです。
この実習ではとりあえずdouble型を使いますが、仕事で金額や厳密な数量を扱う場合は、decimal型など誤差の出にくい型が用意されていますので、それぞれ適切な型の変数を用いるようにするか、誤差が許容されるかどうか、といった検討や工夫を加えてプログラムを作成してください。

### 講師用補足
数値を小数として扱う実習です。C#の場合はdouble型が64bit浮動小数点数で、小数を扱うには一番簡単であることから、ここではdoubleを使っています。浮動小数点値の詳しい話などはここでの説明の範囲を超えるため割愛しますが、講師はある程度質問等に耐えられるよう、事前に調査して学んでおいてください。



## 課題3: 数値以外が入力された場合の対処（オプション課題）
この課題は、課題2までがすんなりと終わった人向けの上級課題です。完成させるには条件文「if」を使う事になると思われるため、習っていない場合は各自Googleなどで検索して使い方を調べつつ作ってみてください。

### 新人用説明文
課題1、課題2ではテキストボックスに数字だけが入る想定のプログラムになっていましたが、実際のアプリケーションでは利用者がどのような文字を入力するか判りません。そこで、誤ってアルファベットや漢字が入力された場合は、計算を行わないような処理を追加してください。

#### 参考: テキストボックスの文字を数値に変換できるか調べつつ変換する
C#には、
- 変換できるかどうか試し、
  - 変換できる → 変数に変換後の数値を入れる。
  - 変換できない → 結果としてFalseを返す

という命令「TryParse」が用意されています。TryParseの利用例は下記の通りです。

```cs
int value;
bool result = 0;
result = int.TryParse(valueString, out value);
```

上記の例では、変換できれば結果がvalue変数に入り、変換できなければvalue変数は0のまま、resultにfalseが設定されます。このあとにresultがtrueかfalseかを判断することで、計算を行うか、行わないかを決めることができます。



---
# サンプルソース概略
こちらは正解サンプルです。

## ArithmeticCalc
例示した画面レイアウトで四則演算の処理を行っています。
足し算のみ、TryParseでの文字/数字判定を行っています。他の処理については、それぞれ演算を行うメソッドを用意してボタンクリックイベントにはあまり複雑な処理を記載しないようにしています。
