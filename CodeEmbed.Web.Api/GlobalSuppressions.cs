//// このファイルは、このプロジェクトに適用される SuppressMessage 
//// 属性を保持するために、コード分析によって使用されます。
//// プロジェクト レベルの抑制には、ターゲットがないものと、特定のターゲット
//// が指定され、名前空間、型、メンバーなどをスコープとするものがあります。
////
//// このファイルに抑制を追加するには、[コード分析] の結果でメッセージを 
//// 右クリックし、[メッセージの非表示] をポイントして、
//// [抑制ファイル内] をクリックします。
//// このファイルに手動で抑制を追加する必要はありません。

[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic", Scope = "member", Target = "CodeEmbed.Web.Api.WebApiApplication.#Application_Start()", Justification = "By specification.")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate", Scope = "member", Target = "CodeEmbed.Web.Api.GitHubUtility.#GetClient()", Justification = "By design.")]
