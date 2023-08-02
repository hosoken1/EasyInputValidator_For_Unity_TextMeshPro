using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace Hosoken.EasyValidator
{
    [CreateAssetMenu(menuName = "TextMeshPro/InputValidator_Allow")]
    public class AllowValidatorAsset : TMP_InputValidator
    {
        [SerializeField] private bool _isAllowHalfWidthAlphabet = true;
        [SerializeField] private bool _isAllowFullWidthAlphabet = true;
        [SerializeField] private bool _isAllowHalfWidthNumber = true;
        [SerializeField] private bool _isAllowFullWidthNumber = true;
        [SerializeField] private bool _isAllowHiragana = true;
        [SerializeField] private bool _isAllowKatakana = true;
        [SerializeField] private bool _isAllowKanji = true;
        [SerializeField] private bool _isAllowPunctuation = true;
        [SerializeField] private bool _isAllowSeparator = true;
        [SerializeField] private bool _isAllowSpace = true;

        public override char Validate(ref string text, ref int pos, char ch)
        {
            // *Validate Character
            // Alphabet
            bool isValidHalfAlphabet = CharacterCheck.IsHalfWidthAlphabet(ch) && _isAllowHalfWidthAlphabet;
            bool isValidFullAlphabet = CharacterCheck.IsFullWidthAlphabet(ch) && _isAllowFullWidthAlphabet;
            // Number
            bool isValidHalfNumber = CharacterCheck.IsHalfWidthNumber(ch) && _isAllowHalfWidthNumber;
            bool isValidFullNumber = CharacterCheck.IsFullWidthNumber(ch) && _isAllowFullWidthNumber;
            // Japanese
            bool isValidHiragana = CharacterCheck.IsHiragana(ch) && _isAllowHiragana;
            bool isValidKatakana = CharacterCheck.IsKatakana(ch) && _isAllowKatakana;
            bool isValidKanji    = CharacterCheck.IsKanji(ch)    && _isAllowKanji;
            // Other
            bool isValidPunctuation = char.IsPunctuation(ch) && _isAllowPunctuation;
            bool isValidWhiteSpace  = char.IsWhiteSpace(ch)  && _isAllowSpace;
            bool isValidSeparator   = char.IsSeparator(ch)   && !char.IsWhiteSpace(ch) && _isAllowSeparator;

            // Determine if characters are valid
            bool isValidCharacter = isValidHalfAlphabet || isValidFullAlphabet ||
                                    isValidHalfNumber   || isValidFullNumber   ||
                                    isValidHiragana     || isValidKatakana     || isValidKanji ||
                                    isValidPunctuation  || isValidWhiteSpace   || isValidSeparator;

            if (isValidCharacter)
            {
                text += ch;
                pos++;
                return ch;
            }
            else
            {
                return '\0';
            }
        }
    }
}