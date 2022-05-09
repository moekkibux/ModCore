﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ModCore.Database;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ModCore.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("ModCore.Database.DatabaseCommandId", b =>
                {
                    b.Property<string>("Command")
                        .HasColumnType("text")
                        .HasColumnName("command_qualified");

                    b.Property<short>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint")
                        .HasColumnName("id")
                        .HasAnnotation("Npgsql:ValueGeneratedOnAdd", true)
                        .HasAnnotation("Sqlite:Autoincrement", true)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<short>("Id"));

                    b.HasKey("Command");

                    b.HasAlternateKey("Id")
                        .HasName("id");

                    b.ToTable("mcore_cmd_state");
                });

            modelBuilder.Entity("ModCore.Database.DatabaseGuildConfig", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<long>("GuildId")
                        .HasColumnType("bigint")
                        .HasColumnName("guild_id");

                    b.Property<string>("Settings")
                        .IsRequired()
                        .HasColumnType("jsonb")
                        .HasColumnName("settings");

                    b.HasKey("Id");

                    b.HasIndex("GuildId")
                        .IsUnique()
                        .HasDatabaseName("mcore_guild_config_guild_id_key");

                    b.ToTable("mcore_guild_config");
                });

            modelBuilder.Entity("ModCore.Database.DatabaseInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("MetaKey")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("meta_key");

                    b.Property<string>("MetaValue")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("meta_value");

                    b.HasKey("Id");

                    b.HasIndex("MetaKey")
                        .IsUnique()
                        .HasDatabaseName("mcore_database_info_meta_key_key");

                    b.ToTable("mcore_database_info");
                });

            modelBuilder.Entity("ModCore.Database.DatabaseModNote", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Contents")
                        .HasColumnType("text")
                        .HasColumnName("contents");

                    b.Property<long>("GuildId")
                        .HasColumnType("bigint")
                        .HasColumnName("guild_id");

                    b.Property<long>("MemberId")
                        .HasColumnType("bigint")
                        .HasColumnName("member_id");

                    b.HasKey("Id");

                    b.HasIndex("MemberId", "GuildId")
                        .IsUnique()
                        .HasDatabaseName("mcore_modnotes_member_id_guild_id_key");

                    b.ToTable("mcore_modnotes");
                });

            modelBuilder.Entity("ModCore.Database.DatabaseRolestateNick", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<long>("GuildId")
                        .HasColumnType("bigint")
                        .HasColumnName("guild_id");

                    b.Property<long>("MemberId")
                        .HasColumnType("bigint")
                        .HasColumnName("member_id");

                    b.Property<string>("Nickname")
                        .HasColumnType("text")
                        .HasColumnName("nickname");

                    b.HasKey("Id");

                    b.HasIndex("MemberId", "GuildId")
                        .IsUnique()
                        .HasDatabaseName("mcore_rolestate_nicks_member_id_guild_id_key");

                    b.ToTable("mcore_rolestate_nicks");
                });

            modelBuilder.Entity("ModCore.Database.DatabaseRolestateOverride", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<long>("ChannelId")
                        .HasColumnType("bigint")
                        .HasColumnName("channel_id");

                    b.Property<long>("GuildId")
                        .HasColumnType("bigint")
                        .HasColumnName("guild_id");

                    b.Property<long>("MemberId")
                        .HasColumnType("bigint")
                        .HasColumnName("member_id");

                    b.Property<long?>("PermsAllow")
                        .HasColumnType("bigint")
                        .HasColumnName("perms_allow");

                    b.Property<long?>("PermsDeny")
                        .HasColumnType("bigint")
                        .HasColumnName("perms_deny");

                    b.HasKey("Id");

                    b.HasIndex("MemberId", "GuildId", "ChannelId")
                        .IsUnique()
                        .HasDatabaseName("mcore_rolestate_overrides_member_id_guild_id_channel_id_key");

                    b.ToTable("mcore_rolestate_overrides");
                });

            modelBuilder.Entity("ModCore.Database.DatabaseRolestateRoles", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<long>("GuildId")
                        .HasColumnType("bigint")
                        .HasColumnName("guild_id");

                    b.Property<long>("MemberId")
                        .HasColumnType("bigint")
                        .HasColumnName("member_id");

                    b.Property<long[]>("RoleIds")
                        .HasColumnType("bigint[]")
                        .HasColumnName("role_ids");

                    b.HasKey("Id");

                    b.HasIndex("MemberId", "GuildId")
                        .IsUnique()
                        .HasDatabaseName("mcore_rolestate_roles_member_id_guild_id_key");

                    b.ToTable("mcore_rolestate_roles");
                });

            modelBuilder.Entity("ModCore.Database.DatabaseStarData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<long>("AuthorId")
                        .HasColumnType("bigint")
                        .HasColumnName("author_id");

                    b.Property<long>("ChannelId")
                        .HasColumnType("bigint")
                        .HasColumnName("channel_id");

                    b.Property<long>("GuildId")
                        .HasColumnType("bigint")
                        .HasColumnName("guild_id");

                    b.Property<long>("MessageId")
                        .HasColumnType("bigint")
                        .HasColumnName("message_id");

                    b.Property<long>("StarboardMessageId")
                        .HasColumnType("bigint")
                        .HasColumnName("starboard_entry_id");

                    b.Property<long>("StargazerId")
                        .HasColumnType("bigint")
                        .HasColumnName("stargazer_id");

                    b.HasKey("Id");

                    b.HasIndex("MessageId", "ChannelId", "StargazerId")
                        .IsUnique()
                        .HasDatabaseName("mcore_stars_member_id_guild_id_key");

                    b.ToTable("mcore_stars");
                });

            modelBuilder.Entity("ModCore.Database.DatabaseTag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<long>("ChannelId")
                        .HasColumnType("bigint")
                        .HasColumnName("channel_id");

                    b.Property<string>("Contents")
                        .HasColumnType("text")
                        .HasColumnName("contents");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamptz")
                        .HasColumnName("created_at");

                    b.Property<string>("Name")
                        .HasColumnType("text")
                        .HasColumnName("tagname");

                    b.Property<long>("OwnerId")
                        .HasColumnType("bigint")
                        .HasColumnName("owner_id");

                    b.HasKey("Id");

                    b.HasIndex("ChannelId", "Name")
                        .IsUnique()
                        .HasDatabaseName("mcore_tags_channel_id_tag_name_key");

                    b.ToTable("mcore_tags");
                });

            modelBuilder.Entity("ModCore.Database.DatabaseTimer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ActionData")
                        .IsRequired()
                        .HasColumnType("jsonb")
                        .HasColumnName("action_data");

                    b.Property<int>("ActionType")
                        .HasColumnType("integer")
                        .HasColumnName("action_type");

                    b.Property<long>("ChannelId")
                        .HasColumnType("bigint")
                        .HasColumnName("channel_id");

                    b.Property<DateTime>("DispatchAt")
                        .HasColumnType("timestamptz")
                        .HasColumnName("dispatch_at");

                    b.Property<long>("GuildId")
                        .HasColumnType("bigint")
                        .HasColumnName("guild_id");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint")
                        .HasColumnName("user_id");

                    b.HasKey("Id");

                    b.ToTable("mcore_timers");
                });

            modelBuilder.Entity("ModCore.Database.DatabaseUserData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Data")
                        .IsRequired()
                        .HasColumnType("jsonb")
                        .HasColumnName("usr_data");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint")
                        .HasColumnName("user_id");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique()
                        .HasDatabaseName("mcore_userdata_user_id_key");

                    b.ToTable("mcore_userdata");
                });
#pragma warning restore 612, 618
        }
    }
}
