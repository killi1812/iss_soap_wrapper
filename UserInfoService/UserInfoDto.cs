using System.Text.Json.Serialization;

namespace soap.UserInfoService;
public class HdProfilePicURLInfo
{
    [JsonPropertyName("url")]
    public bool Url { get; set; }
}
public class BioLinks
{
    [JsonPropertyName("link_type")]
    public string LinkType { get; set; }

    [JsonPropertyName("lynx_url")]
    public string LynxUrl { get; set; } 

    [JsonPropertyName("title")]
    public string Title { get; set; }

    [JsonPropertyName("url")]
    public string Url { get; set; } 
}

public class BiographyWithEntities
{
    [JsonPropertyName("entities")]
    public List<Entity> Entities { get; set; } 
}

public class Entity 
{
    [JsonPropertyName("hashtag")]
    public object Hashtag { get; set; } 

    [JsonPropertyName("user")]
    public UserEntity User { get; set; } 
}

public class UserEntity
{
    [JsonPropertyName("username")]
    public string Username { get; set; }

    [JsonPropertyName("id")]
    public string Id { get; set; } 
}

public class UserInfoDto
{
    [JsonPropertyName("status")]
    public bool Status { get; set; }

    [JsonPropertyName("full_name")]
    public string FullName { get; set; }

    [JsonPropertyName("is_memorialized")]
    public bool IsMemorialized { get; set; }

    [JsonPropertyName("is_private")]
    public bool IsPrivate { get; set; }

    [JsonPropertyName("has_story_archive")]
    public object HasStoryArchive { get; set; } 

    [JsonPropertyName("username")]
    public string Username { get; set; }

    [JsonPropertyName("is_regulated_c18")]
    public bool IsRegulatedC18 { get; set; }

    [JsonPropertyName("regulated_news_in_locations")]
    public List<object> RegulatedNewsInLocations { get; set; } 

    [JsonPropertyName("text_post_app_badge_label")]
    public string TextPostAppBadgeLabel { get; set; }

    [JsonPropertyName("show_text_post_app_badge")]
    public bool ShowTextPostAppBadge { get; set; }

    [JsonPropertyName("pk")]
    public string Pk { get; set; }

    [JsonPropertyName("live_broadcast_visibility")]
    public object LiveBroadcastVisibility { get; set; } 

    [JsonPropertyName("live_broadcast_id")]
    public object LiveBroadcastId { get; set; } 

    [JsonPropertyName("profile_pic_url")]
    public string ProfilePicUrl { get; set; }

    [JsonPropertyName("hd_profile_pic_url_info")]
    public HdProfilePicURLInfo HdProfilePicUrlInfo { get; set; } 

    [JsonPropertyName("is_unpublished")]
    public bool IsUnpublished { get; set; }

    [JsonPropertyName("mutual_followers_count")]
    public object MutualFollowersCount { get; set; } 

    [JsonPropertyName("profile_context_links_with_user_ids")]
    public object ProfileContextLinksWithUserIds { get; set; } 

    [JsonPropertyName("biography_with_entities")]
    public BiographyWithEntities BiographyWithEntities { get; set; } 

    [JsonPropertyName("account_badges")]
    public List<object> AccountBadges { get; set; } 

    [JsonPropertyName("bio_links")]
    public List<BioLinks> BioLinks { get; set; } 

    [JsonPropertyName("external_lynx_url")]
    public string ExternalLynxUrl { get; set; }

    [JsonPropertyName("external_url")]
    public string ExternalUrl { get; set; }

    [JsonPropertyName("has_chaining")]
    public object HasChaining { get; set; } 

    [JsonPropertyName("fbid_v2")]
    public string FbidV2 { get; set; }

    [JsonPropertyName("supervision_info")]
    public object SupervisionInfo { get; set; } 

    [JsonPropertyName("interop_messaging_user_fbid")]
    public string InteropMessagingUserFbid { get; set; }

    [JsonPropertyName("account_type")]
    public int AccountType { get; set; }

    [JsonPropertyName("biography")]
    public string Biography { get; set; }

    [JsonPropertyName("is_embeds_disabled")]
    public bool IsEmbedsDisabled { get; set; }

    [JsonPropertyName("show_account_transparency_details")]
    public bool ShowAccountTransparencyDetails { get; set; }

    [JsonPropertyName("is_verified")]
    public bool IsVerified { get; set; }

    [JsonPropertyName("is_professional_account")]
    public object IsProfessionalAccount { get; set; } 

    [JsonPropertyName("follower_count")]
    public int FollowerCount { get; set; }

    [JsonPropertyName("address_street")]
    public object AddressStreet { get; set; } 

    [JsonPropertyName("city_name")]
    public object CityName { get; set; }

    [JsonPropertyName("is_business")]
    public bool IsBusiness { get; set; }

    [JsonPropertyName("zip")]
    public object Zip { get; set; } 

    [JsonPropertyName("category")]
    public string Category { get; set; }

    [JsonPropertyName("should_show_category")]
    public bool ShouldShowCategory { get; set; }

    [JsonPropertyName("transparency_label")]
    public object TransparencyLabel { get; set; } 

    [JsonPropertyName("transparency_product")]
    public object TransparencyProduct { get; set; }

    [JsonPropertyName("following_count")]
    public int FollowingCount { get; set; }

    [JsonPropertyName("media_count")]
    public int MediaCount { get; set; }

    [JsonPropertyName("latest_reel_media")]
    public object LatestReelMedia { get; set; } 

    [JsonPropertyName("total_clips_count")]
    public int TotalClipsCount { get; set; }

    [JsonPropertyName("latest_besties_reel_media")]
    public object LatestBestiesReelMedia { get; set; } 

    [JsonPropertyName("reel_media_seen_timestamp")]
    public object ReelMediaSeenTimestamp { get; set; }

    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("attempts")]
    public string Attempts { get; set; }

}
