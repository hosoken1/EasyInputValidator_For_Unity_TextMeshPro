using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Hosoken.EasyValidator
{
    public static class CharacterCheck
    {
        // UniCode Table
        // https://www.asahi-net.or.jp/~ax2s-kmtn/ref/unicode/uff00.html

        // Half width alphabet
        const char START_HALF_WIDTH_UPPER_ALPHABET = '\u0041';
        const char END_HALF_WIDTH_UPPER_ALPHABET   = '\u005A';
        const char START_HALF_WIDTH_LOWER_ALPHABET = '\u0061';
        const char END_HALF_WIDTH_LOWER_ALPHABET   = '\u007A';
        // Full width alphabet
        const char START_FULL_WIDTH_UPPER_ALPHABET = '\uFF21';
        const char END_FULL_WIDTH_UPPER_ALPHABET   = '\uFF3A';
        const char START_FULL_WIDTH_LOWER_ALPHABET = '\uFF41';
        const char END_FULL_WIDTH_LOWER_ALPHABET   = '\uFF5A';
        // Half width number
        const char START_HALF_WIDTH_NUMBER = '\u0030';
        const char END_HALF_WIDTH_NUMBER   = '\u0039';
        // Full width number
        const char START_FULL_WIDTH_NUMBER = '\uFF10';
        const char END_FULL_WIDTH_NUMBER   = '\uFF19';
        // Hiragana
        const char START_HIRAGANA = '\u3040';
        const char END_HIRAGANA   = '\u309F';
        // Katakana
        const char START_KATAKANA = '\u30A0';
        const char END_KATAKANA   = '\u30FF';
        // Kanji
        const char START_KANJI = '\u4E00';
        const char END_KANJI   = '\u9FBF';

        public static bool IsHalfWidthAlphabet(char ch)
        {
            return ( ch >= START_HALF_WIDTH_UPPER_ALPHABET && ch <= END_HALF_WIDTH_UPPER_ALPHABET) ||
                    (ch >= START_HALF_WIDTH_LOWER_ALPHABET && ch <= END_HALF_WIDTH_LOWER_ALPHABET);
        }

        public static bool IsFullWidthAlphabet(char ch)
        {
            return ( ch >=  START_FULL_WIDTH_UPPER_ALPHABET && ch <= END_FULL_WIDTH_UPPER_ALPHABET) ||
                    (ch >=  START_FULL_WIDTH_LOWER_ALPHABET && ch <= END_FULL_WIDTH_LOWER_ALPHABET);
        }

        public static bool IsHalfWidthNumber(char ch)
        {
            // 0 ~ 9
            return ch >= START_HALF_WIDTH_NUMBER && ch <= END_HALF_WIDTH_NUMBER;
        }

        public static bool IsFullWidthNumber(char ch)
        {
            // 0 ~ 9
            return ch >= START_FULL_WIDTH_NUMBER && ch <= END_FULL_WIDTH_NUMBER;
        }

        public static bool IsHiragana(char ch)
        {
            // ひらがなのUnicode範囲はU+3040からU+309F
            return ch >= START_HIRAGANA && ch <= END_HIRAGANA;
        }

        public static bool IsKatakana(char ch)
        {
            return ch >= START_KATAKANA && ch <= END_KATAKANA;
        }

        public static bool IsKanji(char ch)
        {
            return ch >= START_KANJI && ch <= END_KANJI;
        }
    }
}