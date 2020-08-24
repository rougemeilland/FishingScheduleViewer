﻿using System.Collections.Generic;

namespace FFXIVFishingScheduleViewer.Models
{
    partial class FishDataVerifier
    {
        private static IDictionary<string, string> _魚のアタリ = new Dictionary<string, string>()
        {
            { "ソルター", "!" },
            { "グレイシャーコア", "!" },
        };

        private static IDictionary<string, bool> _使用可能な釣り餌 = new Dictionary<string, bool>()
        {
            { "シルフランド渓谷@*@ザリガニボール", false }, // 実際には適合する魚がいない
            { "パラタの墓所@*@サスペンドミノー", false }, // 実際には適合する魚がいない
            { "青翠の奈落@*@モスプパ", false }, // 実際には適合する魚がいない
            { "ムーンドリップ洞窟@*@ユスリカ", false }, // 実際には適合する魚がいない
            { "青燐泉@*@バターワーム", false }, // 実際には適合する魚がいない
            { "クルザス不凍池@*@ドバミミズ", false }, // 実際には適合する魚がいない
            { "クルザス不凍池@*@ザザムシ", false }, // 実際には適合する魚がいない
            { "クリアプール@*@ドバミミズ", false }, // 実際には適合する魚がいない
            { "クリアプール@*@ザザムシ", false }, // 実際には適合する魚がいない
            { "唄う裂谷北部@*@バターワーム", false }, // 実際には適合する魚がいない
            { "雲溜まり@*@ザザムシ", false }, // 実際には適合する魚がいない
            { "流星の尾@*@ハニーワーム", false }, // 実際には適合する魚がいない
            { "ゼッキ島近海@*@ポーラークリル", false }, // 実際には適合する魚がいない
            { "七彩溝@*@ブルートリーチ", false }, // 実際には適合する魚がいない

            { "サマーフォード沿岸@*@ファットワーム", false }, // ファットワームはオーシャンフィッシング専用

            { "サプサ産卵地@*@バターワーム", false }, // バターワームは淡水用釣り餌
            { "船隠しの港@*@ハニーワーム", false }, // ハニーワームは淡水用釣り餌
            { "サゴリー砂丘@*@クロウフライ", false }, // クロウフライは淡水用釣り餌
            { "サゴリー砂海@*@シルバースプーン", false }, // シルバースプーンは淡水用釣り餌
            { "ウィッチドロップ@*@ブルートリーチ", false }, // ブルートリーチは淡水用釣り餌
            { "モック・ウーグル島@*@ツチグモ", false }, // ツチグモは淡水用釣り餌
            { "アジス・ラー旗艦島@*@ストーンラーヴァ", false }, // ストーンラーヴァは淡水用釣り餌
            { "アネス・ソー@*@ツチグモ", false }, // ツチグモは淡水用釣り餌
            { "光輪の祭壇@*@カディスラーヴァ", false }, // カディスラーヴァは淡水用釣り餌
            { "光輪の祭壇@*@ツチグモ", false }, // ツチグモは淡水用釣り餌
            { "光輪の祭壇@*@ブルートリーチ", false }, // ブルートリーチは淡水用釣り餌
            { "光輪の祭壇@*@サスペンドミノー", false }, // サスペンドミノーは淡水用釣り餌
            { "サルウーム・カシュ@*@ツチグモ", false }, // ツチグモは淡水用釣り餌
            { "ロッホ・セル湖@*@ドバミミズ", false }, // ドバミミズは淡水用釣り餌
            { "ロッホ・セル湖@*@サスペンドミノー", false }, // サスペンドミノーは淡水用釣り餌
            { "オノコロ島近海@*@スピナーベイト", false }, // スピナーベイトは淡水用釣り餌
            { "ゼッキ島近海@*@ドバミミズ", false }, // ドバミミズは淡水用釣り餌
            { "ゼッキ島近海@*@ザザムシ", false }, // ザザムシは淡水用釣り餌
            { "波止場全体@*@ドバミミズ", false }, // ドバミミズは淡水用釣り餌

            { "ハウケタ御用邸@*@スプーンワーム", false }, // スプーンワームは海釣り用釣り餌
            { "ゴブリン族の生簀@*@スプーンワーム", false }, // スプーンワームは海釣り用釣り餌
            { "ラベンダーベッド@*@シュリンプフィーダー", false }, // シュリンプフィーダーは海釣り用釣り餌
            { "クリアプール@*@アオイソメ", false }, // アオイソメは海釣り用釣り餌
            { "パプスの大樹@*@ポーラークリル", false }, // ポーラークリルは海釣り用釣り餌
            { "ティモン川@*@ラグワーム", false }, // ポーラークリルは海釣り用釣り餌
            { "ラールガーズリーチ@*@活海老", false }, // 活海老は海釣り用釣り餌
            { "スロウウォッシュ@*@活海老", false }, // 活海老は海釣り用釣り餌
            { "ロッホ・セル湖@*@アオイソメ", false }, // アオイソメは海釣り用釣り餌
            { "七彩溝@*@ショートビルミノー", false }, // ショートビルミノーは海釣り用釣り餌
            { "七彩溝@*@アオイソメ", false },  // アオイソメは海釣り用釣り餌
            { "ウォーヴンオウス@*@モエビ", false },  // モエビは海釣り用釣り餌

            { "クリアプール@*@バイオレットワーム", false }, // バイオレットワームは魔泉釣り用釣り餌

            { "アルファ管区@*@マグマワーム", false }, // マグマワームは溶岩釣り用釣り餌
            { "超星間交信塔@*@マグマワーム", false }, // マグマワームは溶岩釣り用釣り餌
            { "アジス・ラー旗艦島@*@マグマワーム", false }, // マグマワームは溶岩釣り用釣り餌

            { "アルファ管区@*@ジャンボガガンボ", false }, // ジャンボガガンボは雲海釣りまたは浮島釣り用釣り餌
            { "廃液溜まり@*@ジャンボガガンボ", false }, // ジャンボガガンボは雲海釣りまたは浮島釣り用釣り餌
            { "アジス・ラー旗艦島@*@ジャンボガガンボ", false }, // ジャンボガガンボは雲海釣りまたは浮島釣り用釣り餌
            { "光輪の祭壇@*@ジャンボガガンボ", false }, // ジャンボガガンボは雲海釣りまたは浮島釣り用釣り餌
            { "ラールガーズリーチ@*@ジャンボガガンボ", false }, // ジャンボガガンボは雲海釣りまたは浮島釣り用釣り餌
            { "アジム・カート@*@ジャンボガガンボ", false }, // ジャンボガガンボは雲海釣りまたは浮島釣り用釣り餌

            { "七彩溝@*@蚕蛹", false }, // 蚕蛹は塩湖用釣り餌

            { "*@*@淡水万能餌", false }, // 万能餌は特定の魚を釣りたい場合にはあまり向かない
            { "*@*@海水万能餌", false }, // 万能餌は特定の魚を釣りたい場合にはあまり向かない
            { "*@*@万能ルアー", false }, // 万能餌は特定の魚を釣りたい場合にはあまり向かない
            { "*@*@メタルスピナー", false }, // お得意様納品用の魚の釣り餌。

            { "七彩溝@橙彩魚@黄彩魚", false }, // データの誤りと思われる

        };
    }
}
