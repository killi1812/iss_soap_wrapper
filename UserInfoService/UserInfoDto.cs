using System.Text.Json.Serialization;

namespace soap.UserInfoService;
using System.Collections.Generic;
using System.Text.Json.Serialization;

// Assumes #nullable enable is active in the project context

public class HdProfilePicURLInfo
{
    [JsonPropertyName("url")]
    public string? Url { get; set; } // Changed type from bool to string? and made nullable
}

public class BioLinks
{
    [JsonPropertyName("link_type")]
    public string? LinkType { get; set; } // Made nullable

    [JsonPropertyName("lynx_url")]
    public string? LynxUrl { get; set; } // Made nullable

    [JsonPropertyName("title")]
    public string? Title { get; set; } // Made nullable

    [JsonPropertyName("url")]
    public string? Url { get; set; } // Made nullable
}

public class BiographyWithEntities
{
    [JsonPropertyName("entities")]
    public List<Entity>? Entities { get; set; } // Made nullable List
}

public class Entity
{
    [JsonPropertyName("hashtag")]
    public object? Hashtag { get; set; } // Made nullable

    [JsonPropertyName("user")]
    public UserEntity? User { get; set; } // Made nullable
}

public class UserEntity
{
    [JsonPropertyName("username")]
    public string? Username { get; set; } // Made nullable

    [JsonPropertyName("id")]
    public string? Id { get; set; } // Made nullable
}

public class UserInfoDto
{
    [JsonPropertyName("status")]
    public bool? Status { get; set; } // Made nullable

    [JsonPropertyName("full_name")]
    public string? FullName { get; set; } // Made nullable

    [JsonPropertyName("is_memorialized")]
    public bool? IsMemorialized { get; set; } // Made nullable

    [JsonPropertyName("is_private")]
    public bool? IsPrivate { get; set; } // Made nullable

    [JsonPropertyName("has_story_archive")]
    public object? HasStoryArchive { get; set; } // Made nullable

    [JsonPropertyName("username")]
    public string? Username { get; set; } // Made nullable

    [JsonPropertyName("is_regulated_c18")]
    public bool? IsRegulatedC18 { get; set; } // Made nullable

    [JsonPropertyName("regulated_news_in_locations")]
    public List<object>? RegulatedNewsInLocations { get; set; } // Made nullable List

    [JsonPropertyName("text_post_app_badge_label")]
    public string? TextPostAppBadgeLabel { get; set; } // Made nullable

    [JsonPropertyName("show_text_post_app_badge")]
    public bool? ShowTextPostAppBadge { get; set; } // Made nullable

    [JsonPropertyName("pk")]
    public string? Pk { get; set; } // Made nullable

    [JsonPropertyName("live_broadcast_visibility")]
    public object? LiveBroadcastVisibility { get; set; } // Made nullable

    [JsonPropertyName("live_broadcast_id")]
    public object? LiveBroadcastId { get; set; } // Made nullable

    [JsonPropertyName("profile_pic_url")]
    public string? ProfilePicUrl { get; set; } // Made nullable

    [JsonPropertyName("hd_profile_pic_url_info")]
    public HdProfilePicURLInfo? HdProfilePicUrlInfo { get; set; } // Made nullable

    [JsonPropertyName("is_unpublished")]
    public bool? IsUnpublished { get; set; } // Made nullable

    [JsonPropertyName("mutual_followers_count")]
    public object? MutualFollowersCount { get; set; } // Made nullable

    [JsonPropertyName("profile_context_links_with_user_ids")]
    public object? ProfileContextLinksWithUserIds { get; set; } // Made nullable

    [JsonPropertyName("biography_with_entities")]
    public BiographyWithEntities? BiographyWithEntities { get; set; } // Made nullable

    [JsonPropertyName("account_badges")]
    public List<object>? AccountBadges { get; set; } // Made nullable List

    [JsonPropertyName("bio_links")]
    public List<BioLinks>? BioLinks { get; set; } // Made nullable List

    [JsonPropertyName("external_lynx_url")]
    public string? ExternalLynxUrl { get; set; } // Made nullable

    [JsonPropertyName("external_url")]
    public string? ExternalUrl { get; set; } // Made nullable

    [JsonPropertyName("has_chaining")]
    public object? HasChaining { get; set; } // Made nullable

    [JsonPropertyName("fbid_v2")]
    public string? FbidV2 { get; set; } // Made nullable

    [JsonPropertyName("supervision_info")]
    public object? SupervisionInfo { get; set; } // Made nullable

    [JsonPropertyName("interop_messaging_user_fbid")]
    public string? InteropMessagingUserFbid { get; set; } // Made nullable

    [JsonPropertyName("account_type")]
    public int? AccountType { get; set; } // Made nullable

    [JsonPropertyName("biography")]
    public string? Biography { get; set; } // Made nullable

    [JsonPropertyName("is_embeds_disabled")]
    public bool? IsEmbedsDisabled { get; set; } // Made nullable

    [JsonPropertyName("show_account_transparency_details")]
    public bool? ShowAccountTransparencyDetails { get; set; } // Made nullable

    [JsonPropertyName("is_verified")]
    public bool? IsVerified { get; set; } // Made nullable

    [JsonPropertyName("is_professional_account")]
    public object? IsProfessionalAccount { get; set; } // Made nullable

    [JsonPropertyName("follower_count")]
    public int? FollowerCount { get; set; } // Made nullable

    [JsonPropertyName("address_street")]
    public object? AddressStreet { get; set; } // Made nullable

    [JsonPropertyName("city_name")]
    public object? CityName { get; set; } // Made nullable

    [JsonPropertyName("is_business")]
    public bool? IsBusiness { get; set; } // Made nullable

    [JsonPropertyName("zip")]
    public object? Zip { get; set; } // Made nullable

    [JsonPropertyName("category")]
    public string? Category { get; set; } // Made nullable

    [JsonPropertyName("should_show_category")]
    public bool? ShouldShowCategory { get; set; } // Made nullable

    [JsonPropertyName("transparency_label")]
    public object? TransparencyLabel { get; set; } // Made nullable

    [JsonPropertyName("transparency_product")]
    public object? TransparencyProduct { get; set; } // Made nullable

    [JsonPropertyName("following_count")]
    public int? FollowingCount { get; set; } // Made nullable

    [JsonPropertyName("media_count")]
    public int? MediaCount { get; set; } // Made nullable

    [JsonPropertyName("latest_reel_media")]
    public object? LatestReelMedia { get; set; } // Made nullable

    [JsonPropertyName("total_clips_count")]
    public int? TotalClipsCount { get; set; } // Made nullable

    [JsonPropertyName("latest_besties_reel_media")]
    public object? LatestBestiesReelMedia { get; set; } // Made nullable

    [JsonPropertyName("reel_media_seen_timestamp")]
    public object? ReelMediaSeenTimestamp { get; set; } // Made nullable

    [JsonPropertyName("id")]
    public string? Id { get; set; } // Made nullable

    [JsonPropertyName("attempts")]
    public string? Attempts { get; set; } // Made nullable
}