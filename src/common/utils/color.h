#pragma once

// helper function to get the RGB from a #FFFFFF string.
inline bool checkValidRGB(std::wstring_view hex, uint8_t* R, uint8_t* G, uint8_t* B)
{
    if (hex.length() != 7)
        return false;
    hex = hex.substr(1, 6); // remove #
    for (auto& c : hex)
    {
        if (!((c >= '0' && c <= '9') || (c >= 'A' && c <= 'F')))
        {
            return false;
        }
    }
    if (swscanf_s(hex.data(), L"%2hhx%2hhx%2hhx", R, G, B) != 3)
    {
        return false;
    }
    return true;
}
