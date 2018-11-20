using System;
using System.Collections.Generic;
using System.Text;

namespace Veeqo.Resources.Domain
{
    public class Payment
    {
        public int id { get; set; }
        public int order_id { get; set; }
        public string payment_type { get; set; }
        public object reference_number { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public object card_number { get; set; }
        public int created_by_id { get; set; }
    }

    public class Features
    {
        public string users { get; set; }
        public string products { get; set; }
        public int orders { get; set; }
        public string stores { get; set; }
        public string support { get; set; }
        public bool? product_pusher { get; set; }
        public bool? stock_take { get; set; }
    }

    public class ChargifyCurrentPlan
    {
        public string name { get; set; }
        public string planId { get; set; }
        public string chargeType { get; set; }
        public string pricing { get; set; }
        public object setup_fee { get; set; }
        public string product_handle { get; set; }
        public object product_url { get; set; }
        public Features features { get; set; }
        public bool? available { get; set; }
    }

    public class Setting
    {
        public string currency_code { get; set; }
        public string phone_number { get; set; }
        public string purchase_order_prefix { get; set; }
    }

    public class SubscriptionPlan
    {
        public int id { get; set; }
        public string name { get; set; }
        public string stripe_plan_id { get; set; }
        public string billing_interval { get; set; }
    }

    public class Company
    {
        public int id { get; set; }
        public string name { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public object referring_website { get; set; }
        public bool? card_valid { get; set; }
        public object stripe_customer_id { get; set; }
        public bool? has_right_to_use_veeqo { get; set; }
        public string subscription_status { get; set; }
        public object billing_period_started { get; set; }
        public int subscription_plan_id { get; set; }
        public string chargify_product_handle { get; set; }
        public ChargifyCurrentPlan chargify_current_plan { get; set; }
        public Setting setting { get; set; }
        public SubscriptionPlan subscription_plan { get; set; }
    }

    public class CreatedBy
    {
        public int id { get; set; }
        public string login { get; set; }
        public string email { get; set; }
        public object location { get; set; }
        public object guide_completed_message_viewed { get; set; }
        public bool? orders_walkthrough_viewed { get; set; }
        public object default_warehouse_id { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public object timezone { get; set; }
        public Company company { get; set; }
    }

    public class DeliveryMethod
    {
        public int id { get; set; }
        public string name { get; set; }
        public double cost { get; set; }
    }

    public class DeliverTo
    {
        public int id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public object email { get; set; }
        public string company { get; set; }
        public string address1 { get; set; }
        public string address2 { get; set; }
        public string city { get; set; }
        public string country { get; set; }
        public string state { get; set; }
        public string zip { get; set; }
        public string phone { get; set; }
    }

    public class Warehouse
    {
        public int id { get; set; }
        public string name { get; set; }
        public object user_id { get; set; }
        public string address_line_1 { get; set; }
        public string address_line_2 { get; set; }
        public string city { get; set; }
        public string region { get; set; }
        public string country { get; set; }
        public string post_code { get; set; }
        public string inventory_type_code { get; set; }
        public double default_min_reorder { get; set; }
        public bool? click_and_collect_enabled { get; set; }
        public object click_and_collect_days { get; set; }
        public int created_by_id { get; set; }
        public object updated_by_id { get; set; }
        public object deleted_at { get; set; }
        public object deleted_by_id { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public string phone { get; set; }
        public bool? requested_carrier_account { get; set; }
        public int display_position { get; set; }
    }

    public class ChannelWarehous
    {
        public int id { get; set; }
        public bool? active { get; set; }
        public double rank { get; set; }
        public Warehouse warehouse { get; set; }
    }

    public class Warehouse2
    {
        public int id { get; set; }
        public string name { get; set; }
    }

    public class Api2cartChannelSpecific
    {
        public int id { get; set; }
        public string url { get; set; }
        public string api2cart_store_key { get; set; }
        public bool? bridge_verified { get; set; }
        public string bridge_url { get; set; }
        public int channel_id { get; set; }
        public bool? multi_store { get; set; }
        public List<object> additional_api2cart_sites { get; set; }
    }

    public class DefaultWarehouse
    {
        public int id { get; set; }
        public string name { get; set; }
        public object user_id { get; set; }
        public string address_line_1 { get; set; }
        public string address_line_2 { get; set; }
        public string city { get; set; }
        public string region { get; set; }
        public string country { get; set; }
        public string post_code { get; set; }
        public string inventory_type_code { get; set; }
        public int default_min_reorder { get; set; }
        public bool? click_and_collect_enabled { get; set; }
        public object click_and_collect_days { get; set; }
        public int created_by_id { get; set; }
        public object updated_by_id { get; set; }
        public object deleted_at { get; set; }
        public object deleted_by_id { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public string phone { get; set; }
        public bool? requested_carrier_account { get; set; }
        public int display_position { get; set; }
    }

    public class Channel
    {
        public int id { get; set; }
        public string type_code { get; set; }
        public int created_by_id { get; set; }
        public string name { get; set; }
        public string short_name { get; set; }
        public string currency_code { get; set; }
        public string state { get; set; }
        public string url { get; set; }
        public object shopify_url { get; set; }
        public object ebay_url { get; set; }
        public int ebay_site_code_id { get; set; }
        public string country { get; set; }
        public string region { get; set; }
        public string city { get; set; }
        public string address_line_1 { get; set; }
        public string address_line_2 { get; set; }
        public string post_code { get; set; }
        public DateTime pulled_products_at { get; set; }
        public DateTime pulled_orders_at { get; set; }
        public bool? pending_setup { get; set; }
        public object seller_id { get; set; }
        public object marketplace_id { get; set; }
        public object mws_auth_token { get; set; }
        public object deleted_at { get; set; }
        public object deleted_by_id { get; set; }
        public string api2cart_store_key { get; set; }
        public string bridge_url { get; set; }
        public bool? bridge_verified { get; set; }
        public bool? pull_pending_orders { get; set; }
        public bool? default_send_shipment_email { get; set; }
        public bool? automatic_product_linking_disabled { get; set; }
        public bool? update_remote_order { get; set; }
        public object successfully_fetched_stock_levels_at { get; set; }
        public bool? create_product_if_unmatched { get; set; }
        public bool? skip_title_matching { get; set; }
        public string email { get; set; }
        public bool? skip_fba_orders_and_products { get; set; }
        public bool? pull_stock_level_required { get; set; }
        public bool? pull_product_properties { get; set; }
        public bool? pull_historical_orders { get; set; }
        public object adjust_orders_tax_rate { get; set; }
        public bool? send_notification_emails_to_customers { get; set; }
        public bool? end_ebay_listing_on_out_of_stock { get; set; }
        public bool? update_product_attributes { get; set; }
        public double max_qty_to_advert { get; set; }
        public double min_threshold_qty { get; set; }
        public double percent_of_qty { get; set; }
        public double always_set_qty { get; set; }
        public bool? veeqo_dictates_stock_level { get; set; }
        public bool? with_fba { get; set; }
        public bool? first_sync_finish_notice_marked_as_read { get; set; }
        public bool? pull_unpaid_shopify_orders { get; set; }
        public bool? create_product_on_ended_listings { get; set; }
        public bool? link_to_products_linked_to_current_channel { get; set; }
        public string weight_unit { get; set; }
        public bool? import_cost_price { get; set; }
        public bool? veeqo_dictates_price { get; set; }
        public bool? keep_inventory_tracking_value { get; set; }
        public object marketplace_country { get; set; }
        public string time_zone { get; set; }
        public object time_zone_offset { get; set; }
        public bool? amazon_fulfillment_enabled { get; set; }
        public bool? import_product_tags { get; set; }
        public bool? import_product_brands { get; set; }
        public object token { get; set; }
        public bool? import_additional_payment_details { get; set; }
        public List<ChannelWarehous> channel_warehouses { get; set; }
        public List<Warehouse2> warehouses { get; set; }
        public List<object> stock_level_update_requests { get; set; }
        public object amazon_fulfillment_setting { get; set; }
        public object amazon_channel_specific { get; set; }
        public Api2cartChannelSpecific api2cart_channel_specific { get; set; }
        public object additional_api2cart_site { get; set; }
        public string time_since_product_sync { get; set; }
        public string time_since_order_sync { get; set; }
        public string time_since_tried_fetch_stock_level { get; set; }
        public object time_since_successfully_fetch_stock_level { get; set; }
        public DefaultWarehouse default_warehouse { get; set; }
        public bool? remote { get; set; }
        public object channel_oauth_refresh_token_expires_at { get; set; }
    }

    public class BillingAddress
    {
        public int id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string address1 { get; set; }
        public string address2 { get; set; }
        public string city { get; set; }
        public string company { get; set; }
        public string country { get; set; }
        public string state { get; set; }
        public string zip { get; set; }
        public string phone { get; set; }
        public object email { get; set; }
    }

    public class ShippingAddress
    {
        public int id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public object email { get; set; }
        public string company { get; set; }
        public string address1 { get; set; }
        public string address2 { get; set; }
        public string city { get; set; }
        public string country { get; set; }
        public string state { get; set; }
        public string zip { get; set; }
        public string phone { get; set; }
    }

    public class Customer
    {
        public int id { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public object mobile { get; set; }
        public int created_by_id { get; set; }
        public BillingAddress billing_address { get; set; }
        public List<ShippingAddress> shipping_addresses { get; set; }
    }

    public class Product
    {
        public int id { get; set; }
        public string title { get; set; }
        public double weight { get; set; }
        public object origin_country { get; set; }
        public object hs_tariff_number { get; set; }
        public double tax_rate { get; set; }
        public object estimated_delivery { get; set; }
        public object deleted_at { get; set; }
        public object deleted_by_id { get; set; }
        public string description { get; set; }
        public string main_image_src { get; set; }
    }

    public class Warehouse3
    {
        public int id { get; set; }
        public string name { get; set; }
        public double display_position { get; set; }
    }

    public class StockEntry
    {
        public int id { get; set; }
        public int sellable_id { get; set; }
        public int warehouse_id { get; set; }
        public bool? infinite { get; set; }
        public double allocated_stock_level { get; set; }
        public object location { get; set; }
        public bool? stock_running_low { get; set; }
        public DateTime updated_at { get; set; }
        public double incoming_stock_level { get; set; }
        public Warehouse3 warehouse { get; set; }
        public double physical_stock_level { get; set; }
        public double available_stock_level { get; set; }
        public double sellable_on_hand_value { get; set; }
    }

    public class VariantOptionSpecific
    {
        public int id { get; set; }
        public int product_specific_id { get; set; }
        public int product_property_id { get; set; }
        public string product_property_name { get; set; }
        public string value { get; set; }
    }

    public class MeasurementAttributes
    {
        public int id { get; set; }
        public double width { get; set; }
        public double height { get; set; }
        public double depth { get; set; }
        public string dimensions_unit { get; set; }
    }

    public class ActiveChannel
    {
        public int id { get; set; }
        public string name { get; set; }
        public string type_code { get; set; }
        public string short_name { get; set; }
    }

    public class Channel2
    {
        public int id { get; set; }
        public string name { get; set; }
        public string type_code { get; set; }
        public bool? veeqo_dictates_price { get; set; }
        public string currency_code { get; set; }
        public string marketplace_country { get; set; }
        public string short_name { get; set; }
    }

    public class ChannelSellable
    {
        public int id { get; set; }
        public string remote_title { get; set; }
        public string remote_sku { get; set; }
        public double remote_price { get; set; }
        public string remote_grams { get; set; }
        public double remote_profit { get; set; }
        public double remote_margin { get; set; }
        public object currency_code { get; set; }
        public int channel_product_id { get; set; }
        public string channel_product_remote_title { get; set; }
        public string channel_product_status { get; set; }
        public int sellable_id { get; set; }
        public List<object> failures { get; set; }
        public Channel2 channel { get; set; }
    }

    public class Inventory
    {
        public bool? infinite { get; set; }
        public double physical_stock_level_at_all_warehouses { get; set; }
        public double allocated_stock_level_at_all_warehouses { get; set; }
        public double available_stock_level_at_all_warehouses { get; set; }
        public double incoming_stock_level_at_all_warehouses { get; set; }
    }

    public class Sellable
    {
        public double total_quantity_sold { get; set; }
        public double allocated_stock_level_at_all_warehouses { get; set; }
        public int id { get; set; }
        public string type { get; set; }
        public string title { get; set; }
        public string sku_code { get; set; }
        public string upc_code { get; set; }
        public string model_number { get; set; }
        public double price { get; set; }
        public double cost_price { get; set; }
        public double min_reorder_level { get; set; }
        public double quantity_to_reorder { get; set; }
        public int created_by_id { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public double weight_grams { get; set; }
        public string weight_unit { get; set; }
        public string product_title { get; set; }
        public string full_title { get; set; }
        public string sellable_title { get; set; }
        public double profit { get; set; }
        public double margin { get; set; }
        public double tax_rate { get; set; }
        public Product product { get; set; }
        public List<StockEntry> stock_entries { get; set; }
        public List<VariantOptionSpecific> variant_option_specifics { get; set; }
        public List<object> variant_property_specifics { get; set; }
        public MeasurementAttributes measurement_attributes { get; set; }
        public List<object> images { get; set; }
        public List<ActiveChannel> active_channels { get; set; }
        public List<ChannelSellable> channel_sellables { get; set; }
        public double available_stock_level_at_all_warehouses { get; set; }
        public double stock_level_at_all_warehouses { get; set; }
        public double on_hand_value { get; set; }
        public Inventory inventory { get; set; }
        public double weight { get; set; }
    }

    public class LineItem
    {
        public int id { get; set; }
        public double quantity { get; set; }
        public double picked_quantity { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public Sellable sellable { get; set; }
    }

    public class Warehouse4
    {
        public string address_line_1 { get; set; }
        public string address_line_2 { get; set; }
        public string city { get; set; }
        public object click_and_collect_days { get; set; }
        public bool? click_and_collect_enabled { get; set; }
        public string country { get; set; }
        public DateTime created_at { get; set; }
        public int created_by_id { get; set; }
        public double default_min_reorder { get; set; }
        public object deleted_at { get; set; }
        public object deleted_by_id { get; set; }
        public int id { get; set; }
        public string inventory_type_code { get; set; }
        public string name { get; set; }
        public string phone { get; set; }
        public string post_code { get; set; }
        public string region { get; set; }
        public double display_position { get; set; }
        public DateTime updated_at { get; set; }
        public object updated_by_id { get; set; }
        public bool? requested_carrier_account { get; set; }
    }

    public class Allocation
    {
        public int id { get; set; }
        public DateTime updated_at { get; set; }
        public DateTime created_at { get; set; }
        public double total_weight { get; set; }
        public string weight_unit { get; set; }
        public int allocated_by_id { get; set; }
        public int order_id { get; set; }
        public object packed_completely { get; set; }
        public object due_date { get; set; }
        public object dispatch_date { get; set; }
        public List<LineItem> line_items { get; set; }
        public object recommended_shipping_options { get; set; }
        public object matched_parcel_properties_criteria { get; set; }
        public object shipment { get; set; }
        public Warehouse4 warehouse { get; set; }
    }

    public class Product2
    {
        public int id { get; set; }
        public string title { get; set; }
        public double weight { get; set; }
        public object origin_country { get; set; }
        public object hs_tariff_number { get; set; }
        public double tax_rate { get; set; }
        public object estimated_delivery { get; set; }
        public object deleted_at { get; set; }
        public object deleted_by_id { get; set; }
        public string description { get; set; }
        public string main_image_src { get; set; }
    }

    public class Warehouse5
    {
        public int id { get; set; }
        public string name { get; set; }
        public double display_position { get; set; }
    }

    public class StockEntry2
    {
        public int id { get; set; }
        public int sellable_id { get; set; }
        public int warehouse_id { get; set; }
        public bool? infinite { get; set; }
        public double allocated_stock_level { get; set; }
        public object location { get; set; }
        public bool? stock_running_low { get; set; }
        public DateTime updated_at { get; set; }
        public double incoming_stock_level { get; set; }
        public Warehouse5 warehouse { get; set; }
        public double physical_stock_level { get; set; }
        public double available_stock_level { get; set; }
        public double sellable_on_hand_value { get; set; }
    }

    public class VariantOptionSpecific2
    {
        public int id { get; set; }
        public double product_specific_id { get; set; }
        public double product_property_id { get; set; }
        public string product_property_name { get; set; }
        public string value { get; set; }
    }

    public class MeasurementAttributes2
    {
        public int id { get; set; }
        public double width { get; set; }
        public double height { get; set; }
        public double depth { get; set; }
        public string dimensions_unit { get; set; }
    }

    public class ActiveChannel2
    {
        public int id { get; set; }
        public string name { get; set; }
        public string type_code { get; set; }
        public string short_name { get; set; }
    }

    public class Channel3
    {
        public int id { get; set; }
        public string name { get; set; }
        public string type_code { get; set; }
        public bool? veeqo_dictates_price { get; set; }
        public string currency_code { get; set; }
        public string marketplace_country { get; set; }
        public string short_name { get; set; }
    }

    public class ChannelSellable2
    {
        public int id { get; set; }
        public string remote_title { get; set; }
        public string remote_sku { get; set; }
        public double remote_price { get; set; }
        public string remote_grams { get; set; }
        public double remote_profit { get; set; }
        public double remote_margin { get; set; }
        public object currency_code { get; set; }
        public double channel_product_id { get; set; }
        public string channel_product_remote_title { get; set; }
        public string channel_product_status { get; set; }
        public double sellable_id { get; set; }
        public List<object> failures { get; set; }
        public Channel3 channel { get; set; }
    }

    public class Inventory2
    {
        public bool? infinite { get; set; }
        public double physical_stock_level_at_all_warehouses { get; set; }
        public double allocated_stock_level_at_all_warehouses { get; set; }
        public double available_stock_level_at_all_warehouses { get; set; }
        public double incoming_stock_level_at_all_warehouses { get; set; }
    }

    public class Sellable2
    {
        public double total_quantity_sold { get; set; }
        public double allocated_stock_level_at_all_warehouses { get; set; }
        public int id { get; set; }
        public string type { get; set; }
        public string title { get; set; }
        public string sku_code { get; set; }
        public string upc_code { get; set; }
        public string model_number { get; set; }
        public double price { get; set; }
        public double cost_price { get; set; }
        public double min_reorder_level { get; set; }
        public double quantity_to_reorder { get; set; }
        public double created_by_id { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public double weight_grams { get; set; }
        public string weight_unit { get; set; }
        public string product_title { get; set; }
        public string full_title { get; set; }
        public string sellable_title { get; set; }
        public double profit { get; set; }
        public double margin { get; set; }
        public double tax_rate { get; set; }
        public Product2 product { get; set; }
        public List<StockEntry2> stock_entries { get; set; }
        public List<VariantOptionSpecific2> variant_option_specifics { get; set; }
        public List<object> variant_property_specifics { get; set; }
        public MeasurementAttributes2 measurement_attributes { get; set; }
        public List<object> images { get; set; }
        public List<ActiveChannel2> active_channels { get; set; }
        public List<ChannelSellable2> channel_sellables { get; set; }
        public double available_stock_level_at_all_warehouses { get; set; }
        public double stock_level_at_all_warehouses { get; set; }
        public double on_hand_value { get; set; }
        public Inventory2 inventory { get; set; }
        public double weight { get; set; }
    }

    public class LineItem2
    {
        public int id { get; set; }
        public double price_per_unit { get; set; }
        public double quantity { get; set; }
        public double tax_rate { get; set; }
        public double taxless_discount_per_unit { get; set; }
        public string additional_options { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public Sellable2 sellable { get; set; }
    }

    public class OrdersResource
    {
        public int id { get; set; }
        public object cancel_reason { get; set; }
        public object refund_amount { get; set; }
        public object send_refund_email { get; set; }
        public object cancelled_at { get; set; }
        public DateTime created_at { get; set; }
        public object customer_viewable_notes { get; set; }
        public double delivery_cost { get; set; }
        public object due_date { get; set; }
        public object dispatch_date { get; set; }
        public bool? international { get; set; }
        public object notes { get; set; }
        public string number { get; set; }
        public bool? receipt_printed { get; set; }
        public bool? send_notification_email { get; set; }
        public object shipped_at { get; set; }
        public string status { get; set; }
        public double subtotal_price { get; set; }
        public double total_discounts { get; set; }
        public double total_price { get; set; }
        public double total_tax { get; set; }
        public double total_fees { get; set; }
        public object buyer_user_id { get; set; }
        public DateTime updated_at { get; set; }
        public Payment payment { get; set; }
        public object till_id { get; set; }
        public bool? fulfilled_by_amazon { get; set; }
        public bool? is_amazon_prime { get; set; }
        public bool? is_amazon_premium_order { get; set; }
        public double additional_order_level_taxless_discount { get; set; }
        public bool? restock_shipped_items { get; set; }
        public double adjustment_amount { get; set; }
        public string currency_code { get; set; }
        public List<object> tags { get; set; }
        public object cancelled_by { get; set; }
        public CreatedBy created_by { get; set; }
        public object updated_by { get; set; }
        public DeliveryMethod delivery_method { get; set; }
        public DeliverTo deliver_to { get; set; }
        public Channel channel { get; set; }
        public Customer customer { get; set; }
        public object customer_note { get; set; }
        public List<Allocation> allocations { get; set; }
        public List<object> employee_notes { get; set; }
        public List<object> returns { get; set; }
        public bool? allocated_completely { get; set; }
        public bool? picked_completely { get; set; }
        public object fulfillment_channel_order { get; set; }
        public List<LineItem2> line_items { get; set; }
    }
}
